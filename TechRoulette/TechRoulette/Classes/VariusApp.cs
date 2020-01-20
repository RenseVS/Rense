using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechRoulette.Classes;
using System.Drawing;
using AForge.Video.DirectShow;
using AForge.Video;

namespace TechRoulette
{
    class VariusApp
    {
        private List<string> gameData;
        private VideoManager videoManager;
        private ArduinoManager arduinoManager;
        private SQLManager sqlManager;
        private List<string> SUserID;
        private List<string> InzetVakje;
        private List<string> SInzetAantal;
        private List<int> UserID;
        private List<int> InzetAantal;
        private List<string> WinningUsers;
        private List<string> ScoreList;

        public VariusApp()
        {
            videoManager = new VideoManager();
            arduinoManager = new ArduinoManager();
            sqlManager = new SQLManager();
            SUserID = new List<string>();
            InzetVakje = new List<string>();
            SInzetAantal = new List<string>();
            UserID = new List<int>();
            InzetAantal = new List<int>();
            WinningUsers = new List<string>();
            ScoreList = new List<string>();
            gameData = new List<string>();
        }

        //arduino
        public void ArduinoProgramSelect(char command)
        {
            arduinoManager.ProgramSelection(command);
        }

        public bool ArduinoMessageChecker(string message)
        {
            bool validMessage = arduinoManager.MessageChecker(message);
            return validMessage;
        }
        public void SendMessageArduino(string input)
        {
            arduinoManager.SendMessageArduino(input);
        }
        public bool DisconnectToArduino()
        {
            return arduinoManager.DisconnectToArduino();
        }
        public string CommandRecieve(string input)
        {
            return arduinoManager.NewPortRecieve(input);
        }
        public bool ConnectToArduino()
        {
            return arduinoManager.ConnectToArduino();
        }
        public string arduinoSpeed()
        {
            return Convert.ToString(arduinoManager.arduinoSpeed);
        }
        public string arduinoCOM()
        {
            return arduinoManager.arduinoCOM;
        }
        //Camera
        public void ImageProcessStart(Bitmap imageBall, Bitmap imageNull)
        {
            videoManager.ImageProcessStart(imageBall, imageNull);
        }
        public void StopCamera(VideoCaptureDevice WebcamDevice)
        {
            videoManager.StopCamera(WebcamDevice);
        }
        public Number resultaten()
        {
            return videoManager.GetWinner();
        }
        public Number resultaten(string Betawinner)
        {
            return videoManager.GetWinner(Betawinner);
        }
        //sql
        public void NewSQL(string Connection)
        {
            sqlManager.UpdatemySQLConnection(Connection);
        }
        public void LastBet()
        {
            sqlManager.LastBet();
        }
        private void GroteSchoonmaak()
        {
            SUserID.Clear();
            UserID.Clear();
            SInzetAantal.Clear();
            InzetAantal.Clear();
            InzetVakje.Clear();
            WinningUsers.Clear();
            sqlManager.GroteSchoonmaak();
        }
        public List<string> winners(int winner, string color, string Column, string row, string half, string even)
        {
            ScoreList.Clear();
            int i = 0;
            string winnerstring = Convert.ToString(winner);
            SUserID = sqlManager.RetrieveUserID(winnerstring, color, Column, row, half, even);
            InzetVakje = sqlManager.RetrieveVakje(winnerstring, color, Column, row, half, even);
            SInzetAantal = sqlManager.RetrieveInzet(winnerstring, color, Column, row, half, even);

            UserID = SUserID.ConvertAll<int>(Convert.ToInt32);
            WinningUsers = sqlManager.RetrieveUsers(UserID);
            InzetAantal = SInzetAantal.ConvertAll<int>(Convert.ToInt32);
            foreach (string InzetVak in InzetVakje)
            {
                if ((InzetVak == color) || (InzetVak == even) || (InzetVak == half))
                {
                    InzetAantal[i] = InzetAantal[i] * 2;
                }
                if ((InzetVak == Column) || (InzetVak == row))
                {
                    InzetAantal[i] = InzetAantal[i] * 3;
                }
                if (InzetVak == winnerstring)
                {
                    InzetAantal[i] = InzetAantal[i] * 36;
                }
                i++;
            }
            int j = 0;
            foreach (string name in WinningUsers)
            {
                ScoreList.Add(name + ": " + InzetAantal[j]);
                j++;
            }
            sqlManager.SendResults(UserID, InzetAantal);
            int TotaalWinst = 0;
            foreach (int Winst in InzetAantal)
            {
                TotaalWinst = TotaalWinst + Winst;
            }
            sqlManager.SendData(winnerstring, color, Column, row, half, even, TotaalWinst);
            GroteSchoonmaak();
            return ScoreList;
        }
        public List<string> GameData()
        {
            gameData.Clear();
            gameData.Add(sqlManager.HotNumber());
            gameData.Add(sqlManager.HotEvenOdd());
            gameData.Add(sqlManager.HotRow());
            gameData.Add(sqlManager.HotHalf());
            gameData.Add(sqlManager.HotColumn());
            gameData.Add(sqlManager.HotColor());
            return gameData;
        }
        //top10sql
        public List<string> RetrieveTop10()
        {
            return sqlManager.RetrieveTop10();
        }

        public void ResetLists()
        {
            sqlManager.ResetLists();
        }
    }
}
