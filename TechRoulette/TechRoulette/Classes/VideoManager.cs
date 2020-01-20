using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;
using AForge.Imaging;
using AForge.Math;
using AForge.Math.Geometry;


namespace TechRoulette.Classes
{

    class VideoManager
    {
        private Numbers numbers = new Numbers();
        private Bitmap ballBitmap;
        private Bitmap nullPointBitmap;
        private float[] ballCoordinates = new float[2];
        private float[] nullPointCoordinates = new float[2];
        private double correlationCoefficientBall, correlationCoefficientNullPoint;
        private List<string> rouletteWheelList = new List<string>();
        private string spaceWon;

        public VideoManager() => FillRouletteWheel();

        private void FillRouletteWheel()
        {
            // 0 at start is 0, other is 00
            rouletteWheelList.Add("0");
            rouletteWheelList.Add("2");
            rouletteWheelList.Add("14");
            rouletteWheelList.Add("35");
            rouletteWheelList.Add("23");
            rouletteWheelList.Add("4");
            rouletteWheelList.Add("16");
            rouletteWheelList.Add("32");
            rouletteWheelList.Add("21");
            rouletteWheelList.Add("6");
            rouletteWheelList.Add("18");
            rouletteWheelList.Add("31");
            rouletteWheelList.Add("19");
            rouletteWheelList.Add("8");
            rouletteWheelList.Add("12");
            rouletteWheelList.Add("29");
            rouletteWheelList.Add("25");
            rouletteWheelList.Add("10");
            rouletteWheelList.Add("27");
            rouletteWheelList.Add("00");
            rouletteWheelList.Add("1");
            rouletteWheelList.Add("13");
            rouletteWheelList.Add("36");
            rouletteWheelList.Add("24");
            rouletteWheelList.Add("3");
            rouletteWheelList.Add("15");
            rouletteWheelList.Add("34");
            rouletteWheelList.Add("22");
            rouletteWheelList.Add("5");
            rouletteWheelList.Add("17");
            rouletteWheelList.Add("32");
            rouletteWheelList.Add("20");
            rouletteWheelList.Add("7");
            rouletteWheelList.Add("11");
            rouletteWheelList.Add("30");
            rouletteWheelList.Add("26");
            rouletteWheelList.Add("9");
            rouletteWheelList.Add("28");
        }

        // Camera & Image Processing
        public void StopCamera(VideoCaptureDevice WebcamDevice)
        {
            if (WebcamDevice.IsRunning)
            {
                WebcamDevice.Stop();
            }
        }

        public void ImageProcessStart(Bitmap importedImageball, Bitmap importedImageNull)
        {
            ballBitmap = importedImageball;
            nullPointBitmap = importedImageNull;
            
            BitMapSave("PreFilter");
             HSLFilter_White();
            BitMapSave("BetweenFilter");
            HSLFilter_Pink();
            BitMapSave("Filters");

            BlobFinder(10,10,100,100,0);
            BlobFinder(8,8,60,60,1);

            GeneralCalculation();
            
        }
        private void BitMapSave(string stage)
        {
            ballBitmap.Save("BallBitMap"+stage+".bmp", ImageFormat.Bmp);
            nullPointBitmap.Save("NullPointBitMap" + stage+".bmp", ImageFormat.Bmp);
        }

        private void BlobFinder(int blobMinHeight, int blobMinWidth, int blobMaxHeight, int blobMaxWidth, int bitmapNo)
        {
            BlobCounterBase blobCounterBase = new BlobCounter();
            Bitmap image = ballBitmap;
            
            blobCounterBase.FilterBlobs = true;
            blobCounterBase.MinHeight = blobMinHeight;
            blobCounterBase.MinWidth = blobMinWidth;
            blobCounterBase.MaxHeight = blobMaxHeight;
            blobCounterBase.MaxWidth = blobMaxWidth;

            blobCounterBase.ObjectsOrder = ObjectsOrder.Size;

            switch (bitmapNo)
            {
                case 0:
                    {
                        image = ballBitmap;
                        break;
                    }
                case 1:
                    {
                        image = nullPointBitmap;
                        break;
                    }
                default:
                    break;
            }

            blobCounterBase.ProcessImage(image);
            Blob[] blobs = blobCounterBase.GetObjectsInformation();

            if (blobs.Length > 0)
            {
                Blob ballBlob = blobs[0];
                Console.WriteLine(ballBlob.CenterOfGravity);
                switch (bitmapNo)
                {
                    case 0:
                        {
                            ballCoordinates[0] = ballBlob.CenterOfGravity.X;
                            ballCoordinates[1] = ballBlob.CenterOfGravity.Y;
                            break;
                        }
                    case 1:
                        {
                            nullPointCoordinates[0] = ballBlob.CenterOfGravity.X;
                            nullPointCoordinates[1] = ballBlob.CenterOfGravity.Y;
                            break;
                        }
                    default:
                        break;
                }
            }
            else
            {
                throw new Exception("No Blobs found (Is the Filter properly setup?)");
            }
        }

        // Stel Filters af
        private void HSLFilter_White()
        {
            HSLFiltering filterWhite = new HSLFiltering
            {
                Hue = new IntRange(20, 40),
                Saturation = new Range(0.09f, 1),
                Luminance = new Range(0.8f, 1)
            };

            filterWhite.ApplyInPlace(ballBitmap);
        }

        private void HSLFilter_Pink()
        {
            // Adapt
            HSLFiltering filterBlue = new HSLFiltering
            {
                Hue = new IntRange(220, 260),
                Saturation = new Range(0.6f, 1),
                Luminance = new Range(0.2f, 0.8f)
            };

            filterBlue.ApplyInPlace(nullPointBitmap);
        }

        /* Math
         In y=a*x+b, b=0 because the line crosses the Y Axis in (0,0)
         Therefore, one of the values will also be (0,0)
         */
         
        private void GeneralCalculation()
        {
            double angleBall;
            FormulaSetup();
            angleBall = AngleCalculation();
            IsolateNumber(angleBall);
            Console.WriteLine("Reached the end successfully, no syntax errors were found!");
        }

        private void IsolateNumber(double angleBall)
        {
            int indexNo = 0, numberOfCycles = 1;
            bool stringIsEqual = false;
            string numberName;

            double singleSection = 360 / 38;
            string result = Convert.ToString(angleBall / singleSection);
            Console.WriteLine("The Value is: " + result);

            while(stringIsEqual != true && numberOfCycles >= 3)
            {
               stringIsEqual = String.Equals(result, rouletteWheelList[indexNo]);
                if (stringIsEqual != true)
                {
                    indexNo++;
                }
                if (indexNo > rouletteWheelList.Count)
                {
                    indexNo = 0;
                    numberOfCycles++;
                }

            }
            if (numberOfCycles <= 3)
            {
                throw new Exception("NOT FOUND.");
            }

            numberName = rouletteWheelList[indexNo];
            Console.WriteLine("The successful number is: " + numberName);

        }

        private double AngleCalculation()
        {
          string Value = Convert.ToString((correlationCoefficientBall / correlationCoefficientNullPoint));
            if (Value == "NaN")
            {
                throw new Exception("Value of Value (Division of correlationValues) is NAN");
            }
            Double.TryParse(Value, out double result);
          Math.Tan(result);
          return Math.Round(Convert.ToDouble(result));
        }

        private void FormulaSetup()
        {
            correlationCoefficientBall = CorrelationCoefficient(0);
            correlationCoefficientNullPoint = CorrelationCoefficient(1);
            Console.WriteLine("The Correlation of Ball is: " + correlationCoefficientBall);
            Console.WriteLine("The Correlation of NullPoint is: " + correlationCoefficientNullPoint);

        }

        private double CorrelationCoefficient(int FormulaNo)
        {
            float aY, bY, aX, bX;

            switch (FormulaNo)
            {
                case 0:
                    {
                        if (ballCoordinates[0] > 0 && ballCoordinates[1] > 0)
                        {
                            aX = ballCoordinates[0];
                            aY = ballCoordinates[1];
                            bX = 0;
                            bY = 0;
                        }
                        else
                        {
                            aX = 0;
                            aY = 0;
                            bX = ballCoordinates[0]; 
                            bY = ballCoordinates[1];
                        }
                        break;
                    }
                case 1:
                    {
                        if (nullPointCoordinates[0] > 0 && nullPointCoordinates[1] > 0)
                        {
                            aX = nullPointCoordinates[0];
                            aY = nullPointCoordinates[1];
                            bX = 0;
                            bY = 0;
                        }
                        else
                        {
                            aX = 0;
                            aY = 0;
                            bX = nullPointCoordinates[0];
                            bY = nullPointCoordinates[1];
                        }
                        break;
                    }

                default:
                    Console.WriteLine("Failed at FormulaNo: " + FormulaNo);
                    throw new Exception("NullPoint Linear Formula Failed Or Ball Linear Formula Failed.");
            }
            Console.WriteLine(FormulaNo);
            double CorrelationCoefficient = Convert.ToDouble((aY - bY) / (aX - bX));

            return CorrelationCoefficient;
        }

        public Number GetWinner()
        {
            int winner;
            // Hier RENSES Code voor Numbers
            if (spaceWon == "00")
            {
                winner = 37;
            }
            else
            {
                winner = Convert.ToInt32(spaceWon);
            }
            return numbers.Resultaten(winner);
        }
        public Number GetWinner(string Betawinner)
        {
            int winner = Convert.ToInt32(Betawinner);
            return numbers.Resultaten(winner);
        }
    }
}