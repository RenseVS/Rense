using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechRoulette.Classes
{
    class ArduinoManager
    {
        private Timer readMessageTimer;
        public string arduinoCOM { get; set; }
        public int arduinoSpeed { get; }
        private SerialMessenger serialMessenger;
        public List<string> SerialList = new List<string>();

        public bool ConnectToArduino()
        {
            try
            {
                serialMessenger.Connect();
                readMessageTimer.Enabled = true;
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }

        public bool DisconnectToArduino()
        {
            try
            {
                readMessageTimer.Enabled = false;
                serialMessenger.Disconnect();
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }

        public ArduinoManager()
        {
            arduinoCOM = "COM8";
            arduinoSpeed = 9600;
            SetupManager();
        }   

        private void SetupManager()
        {
            MessageBuilder messageBuilder = new MessageBuilder();
            serialMessenger = new SerialMessenger(arduinoCOM, arduinoSpeed, messageBuilder);

            readMessageTimer = new Timer();
            readMessageTimer.Interval = 10;
            readMessageTimer.Tick += new EventHandler(ReadMessageTimer_Tick);
        }

        public void ReadMessageTimer_Tick(object sender, EventArgs e)
        {
            string message = serialMessenger.ReadMessages();
            if (message != null && message != "")
            {
                ProcessReceivedMessage(message);
            }
        }

        public bool MessageChecker(string message)
        {
            bool correctMessage = false;

            return correctMessage;
        }

        public void SendMessageArduino(string message)
        {
            serialMessenger.SendMessage(message);
        }

        // Arduino Message Handling
        private void ProcessReceivedMessage(string message)
        {
            // First trim whitespace characters like a trailing '\r'.
            // This is needed because the Arduino Serial.println adds \r\n.
            // '\n' will be removed because this is used as the message separation character,
            // but the '\r' must also be removed, otherwise comparing the message strings will not work.
            message = message.Trim('\r', '\n');
            // Add message to the listBox.
            // NAN
            Console.WriteLine(message);

            switch (message)
            {
                case "Finish":
                    { 

                        break;
                    }

                default:
                    {
                        Console.WriteLine("Invalid Signal: " + message);
                        break;
                    }
            }
        }

        public string NewPortRecieve(string newPort)
        {
            string changedPort = ChangePort(newPort);
            return changedPort;
        }

        private string ChangePort (string newPort)
        {
            arduinoCOM = newPort;
            return arduinoCOM;
        }

        public void ProgramSelection(Char message)
        {
            switch (message)
            {
                case 'j':
                    {
                        SendMessageArduino("j");
                        break;
                    }
                case 'w':
                    {
                        SendMessageArduino("w");
                        break;
                    }
                case 'l':
                    {
                        SendMessageArduino("l");
                        break;
                    }
                case 's':
                    {
                        SendMessageArduino("s");
                        break;
                    }
                case 'd':
                    {
                        SendMessageArduino("d");
                        break;
                    }
                case 'g':
                    {
                        SendMessageArduino("g");
                        break;
                    }
                case 'r':
                    {
                        SendMessageArduino("r");
                        break;
                    }
                default:
                    break;
            }
        }

    }
}
