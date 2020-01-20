using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TechRoulette.Classes;
using MySql.Data.MySqlClient;
using AForge.Video.DirectShow;
using AForge.Video;

namespace TechRoulette
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection VideoCaptureDevices;
        private VideoCaptureDevice WebcamDevice;
        private VariusApp variusApp;
        private Bitmap bitMapBallExport, bitMapNullExport;

        private string betawinner;
        private bool Lastround;
        private Forms forms;
        private bool inzetfase;
        
        public Form1()
        {
            Lastround = false;
            inzetfase = true;
            betawinner = "0";
            forms = new Forms();
            variusApp = new VariusApp();
            forms.AddForm(this);  
            InitializeComponent();
            SetReadableValues();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            manageComboBox();
            Form2 form2 = new Form2();
            form2.Show();
            this.Owner = form2;
            forms.AddForm(form2);
        }
        // arduino
        private void SetReadableValues()
        {
            BoardPortTextBox.Text = variusApp.arduinoCOM();
            BaudRateTextBox.Text = variusApp.arduinoSpeed();
            DatasourceSQLTextbox.Text = "datasource=192.168.242.69;";
            PortSQLTextbox.Text = "port=3306;";
            UsernameSQLTextbox.Text = "username=admin;";
            PasswordSQLTextbox.Text = "password=root;";
        }

        private void ConnectArduinoButton_Click(object sender, EventArgs e)
        {
            if (variusApp.ConnectToArduino())
            {
                ArduinoConnectionTextBox.BackColor = Color.Green;
                ArduinoConnectionTextBox.Text = "CONNECTED";
            }
        }

        private void ArduinoChangeValuesButton_Click(object sender, EventArgs e)
        {
            BoardPortTextBox.Text = variusApp.CommandRecieve(BoardPortTextBox.Text);
        }

        private void DisconnectArduinoButton_Click(object sender, EventArgs e)
        {
            if (variusApp.DisconnectToArduino())
            {
                ArduinoConnectionTextBox.BackColor = Color.Red;
                ArduinoConnectionTextBox.Text = "DISCONNECTED";
            }
        }

        private void MotorStartButton_Click(object sender, EventArgs e)
        {
            variusApp.SendMessageArduino("s");
        }

        private void StopMotorButton_Click(object sender, EventArgs e)
        {
            variusApp.SendMessageArduino("d");

        }

        private void ConnectionChangeButton_Click(object sender, EventArgs e)
        {
            variusApp.NewSQL ("datasource=" + DatasourceSQLTextbox.Text + ";" + "port=" + PortSQLTextbox.Text + ";" + "username=" + UsernameSQLTextbox.Text + ";" + "password=" + PasswordSQLTextbox.Text);
        }
        // camera
        private void StopCamera_Click(object sender, EventArgs e)
        {
            variusApp.StopCamera(WebcamDevice);
        }

        private void CameraButtonStart_Click(object sender, EventArgs e)
        {
            StartCamera();
        }

        public void StartCamera()
        {

            WebcamDevice = new VideoCaptureDevice(VideoCaptureDevices[CameraListComboBox.SelectedIndex].MonikerString);
            WebcamDevice.NewFrame += WebcamDevice_NewFrame;
            WebcamDevice.Start();
            TimerVideo.Enabled = true;
            TimerVideo.Tick += new EventHandler(TimerVideoProccessor);
        }

        private void TimerVideoProccessor(object sender, EventArgs e)
        {
            WebcamDevice.Stop();
            TimerVideo.Enabled = false;
            variusApp.ImageProcessStart(bitMapBallExport, bitMapNullExport);

        }

        public void WebcamDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitMapBall = (Bitmap)eventArgs.Frame.Clone();
            Bitmap bitMapNull = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bitMapBall;
            pictureBox1.Image = bitMapNull;
            bitMapBallExport = bitMapBall;
            bitMapNullExport = bitMapNull;
        }

        private void manageComboBox()
        {
            int cameraAmount = 0;
            VideoCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in VideoCaptureDevices)
            {
                cameraAmount++;
                CameraListComboBox.Items.Add("Camera " + cameraAmount);
            }
          // CameraListComboBox.SelectedIndex = 1;
        }
        
        // Programma
        private void Result()
        {
            forms.Result(variusApp.resultaten());
            ResultTimer.Start();
        }
        private void Result(string Betawinner)
        {
            forms.Result(variusApp.resultaten(Betawinner));
            ResultTimer.Start();
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            forms.Refresh(inzetfase, variusApp.RetrieveTop10());
            variusApp.ResetLists();
        }

        private void ResetBoard()
        {
            if (Lastround == false)
            {
                forms.GameData(variusApp.GameData());
                inzetfase = true;
                Refresh();
                Refreshtimer.Start();
                GameTimer.Start();
                forms.Start();
            }
            else
            {
                Lastround = false;
            }

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            GameTimer.Stop();
            Refreshtimer.Stop();
            variusApp.LastBet();
            RefreshData();
            inzetfase = false;
            RefreshData();
            if (CameraListComboBox.SelectedIndex == 1)
            {
                //Start Wheel
                // Start motor, preform actions required for game
                variusApp.ArduinoProgramSelect('s');         // Motor Start
                CreateMotorTimer();                          // Wait X time
                bool validMessage = false;
                while (validMessage == false)
                {
                    validMessage = variusApp.ArduinoMessageChecker("Finish");
                }
                StartCamera();
                Result();
            }
            else
            {
                Console.WriteLine("Verander naar goede camera of voer handmatig in.");
            }
        }

        private void CreateMotorTimer()
        {
            System.Windows.Forms.Timer motorTimer = new Timer();
            motorTimer.Interval = 20000;
            motorTimer.Tick += MotorTimer_Tick;
        }

        private void MotorTimer_Tick(object sender, EventArgs e)
        {
            variusApp.ArduinoProgramSelect('d');

        }

        private void ResultTimer_Tick(object sender, EventArgs e)
        {
            ResultTimer.Stop();
            ResetBoard();
        }
        public List<string> Payout(int winner, string winColor, string winColumn, string winRowSet, string winHalf, string winEven)
        {
            return variusApp.winners(winner, winColor, winColumn, winRowSet, winHalf, winEven);
        }

        private void Winner_Click(object sender, EventArgs e)
        {
            betawinner = BetaTextBox.Text;
            if (betawinner == "00")
            {
                betawinner = "37";
            }
            Result(betawinner);
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            forms.GameData(variusApp.GameData());
            forms.Start();
            GameTimer.Start();
            Refreshtimer.Start();
            RefreshData();
            inzetfase = true;
        }

        private void StopGame_Click(object sender, EventArgs e)
        {
            Lastround = true;
        }
    }
}