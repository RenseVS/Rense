using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechRoulette
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private PictureBox[] ChipSpaces;
        private Image[] imagenumbers;
        private int CountDown = 0;
        private List<int> IntTop10;

        private void Form2_Load(object sender, EventArgs e)
        {
    //        this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            IntTop10 = new List<int>();
            imagenumbers = new Image[38];
            ChipSpaces = new PictureBox[51];
            addcard();
            addnumberpics();
        }
        public void ConvertTop10(List<string> Top10)
        {
            for (int i = 0; i < Top10.Count; i++)
            {
                switch (Top10[i])
                {
                    case "00":
                        Top10[i] = "37";
                        break;
                    case "Column1":
                        Top10[i] = "38";
                        break;
                    case "Column2":
                        Top10[i] = "39";
                        break;
                    case "Column3":
                        Top10[i] = "40";
                        break;
                    case "RowSet1":
                        Top10[i] = "41";
                        break;
                    case "Rowset2":
                        Top10[i] = "42";
                        break;
                    case "Rowset3":
                        Top10[i] = "43";
                        break;
                    case "Half1":
                        Top10[i] = "44";
                        break;
                    case "Half2":
                        Top10[i] = "45";
                        break;
                    case "Even":
                        Top10[i] = "46";
                        break;
                    case "Odd":
                        Top10[i] = "47";
                        break;
                    case "Red":
                        Top10[i] = "48";
                        break;
                    case "Black":
                        Top10[i] = "49";
                        break;
                }
            }
            IntTop10 = Top10.ConvertAll<int>(Convert.ToInt32);
            for (int i = 10; IntTop10.Count < 10; i--)
            {
                IntTop10.Add(50);
            }
            RefreshTop10(IntTop10);
        }

        public void Nobets()
        {
            WinningNumberPic.Image = Properties.Resources.NoBets;
        }

        private void RefreshTop10(List<int> Top10)
        {
                for (int i = 0; i < 51; i++)
                {
                    ChipSpaces[i].Image = null;
                }
                ChipSpaces[Top10[0]].Image = Properties.Resources.Drie_chips;
                ChipSpaces[Top10[1]].Image = Properties.Resources.Drie_chips;
                ChipSpaces[Top10[2]].Image = Properties.Resources.Drie_chips;
                ChipSpaces[Top10[3]].Image = Properties.Resources.Twee_chips;
                ChipSpaces[Top10[4]].Image = Properties.Resources.Twee_chips;
                ChipSpaces[Top10[5]].Image = Properties.Resources.Twee_chips;
                ChipSpaces[Top10[6]].Image = Properties.Resources.Enkele_chip;
                ChipSpaces[Top10[7]].Image = Properties.Resources.Enkele_chip;
                ChipSpaces[Top10[8]].Image = Properties.Resources.Enkele_chip;
                ChipSpaces[Top10[9]].Image = Properties.Resources.Enkele_chip;
                WinningNumberPic.Image = Properties.Resources.Bets;
                ColomLabel.Text = "Column: ";
                RowLabel.Text = "Row: ";
                HalfLabel.Text = "Half: ";
                EvenLabel.Text = "Even/Odd: ";
        }

        public void GameData(List<string> list)
        {
            Statestieken.Items.Clear();
            Statestieken.Items.Add("Hot Number: " + list[0]);
            Statestieken.Items.Add("Hot Even/Odd: " + list[1]);
            Statestieken.Items.Add("Hot Row: " + list[2]);
            Statestieken.Items.Add("Hot Half: " + list[3]);
            Statestieken.Items.Add("Hot Column: " + list[4]);
            Statestieken.Items.Add("Hot Color: " + list[5]);
        }

        public void Start()
        {
            Winnerlistbox.Items.Clear();
            CountDown = 0;
            CountDownTimer.Start();
        }

        private void addcard()
        {
             ChipSpaces[0] = space0;
             ChipSpaces[1] = space1;
             ChipSpaces[2] = space2;
             ChipSpaces[3] = space3;
             ChipSpaces[4] = space4;
             ChipSpaces[5] = space5;
             ChipSpaces[6] = space6;
             ChipSpaces[7] = space7;
             ChipSpaces[8] = space8;
             ChipSpaces[9] = space9;
             ChipSpaces[10] = space10;
             ChipSpaces[11] = space11;
             ChipSpaces[12] = space12;
             ChipSpaces[13] = space13;
             ChipSpaces[14] = space14;
             ChipSpaces[15] = space15;
             ChipSpaces[16] = space16;
             ChipSpaces[17] = space17;
             ChipSpaces[18] = space18;
             ChipSpaces[19] = space19;
             ChipSpaces[20] = space20;
             ChipSpaces[21] = space21;
             ChipSpaces[22] = space22;
             ChipSpaces[23] = space23;
             ChipSpaces[24] = space24;
             ChipSpaces[25] = space25;
             ChipSpaces[26] = space26;
             ChipSpaces[27] = space27;
             ChipSpaces[28] = space28;
             ChipSpaces[29] = space29;
             ChipSpaces[30] = space30;
             ChipSpaces[31] = space31;
             ChipSpaces[32] = space32;
             ChipSpaces[33] = space33;
             ChipSpaces[34] = space34;
             ChipSpaces[35] = space35;
             ChipSpaces[36] = space36;
             ChipSpaces[37] = space00;
             // end of numbers
             ChipSpaces[38] = colom1;
             ChipSpaces[39] = colom2;
             ChipSpaces[40] = colom3;
             ChipSpaces[41] = row1;
             ChipSpaces[42] = row2;
             ChipSpaces[43] = row3;
             ChipSpaces[44] = half1;
             ChipSpaces[45] = half2;
             ChipSpaces[46] = even;
             ChipSpaces[47] = odd;
             ChipSpaces[48] = red;
             ChipSpaces[49] = black;
             ChipSpaces[50] = NULLBox; 
        }
        private void addnumberpics()
        {
            imagenumbers[0] = Properties.Resources.pic0;
            imagenumbers[1] = Properties.Resources.pic1;
            imagenumbers[2] = Properties.Resources.pic2;
            imagenumbers[3] = Properties.Resources.pic3;
            imagenumbers[4] = Properties.Resources.pic4;
            imagenumbers[5] = Properties.Resources.pic5;
            imagenumbers[6] = Properties.Resources.pic6;
            imagenumbers[7] = Properties.Resources.pic7;
            imagenumbers[8] = Properties.Resources.pic8;
            imagenumbers[9] = Properties.Resources.pic9;
            imagenumbers[10] = Properties.Resources.pic10;
            imagenumbers[11] = Properties.Resources.pic11;
            imagenumbers[12] = Properties.Resources.pic12;
            imagenumbers[13] = Properties.Resources.pic13;
            imagenumbers[14] = Properties.Resources.pic14;
            imagenumbers[15] = Properties.Resources.pic15;
            imagenumbers[16] = Properties.Resources.pic16;
            imagenumbers[17] = Properties.Resources.pic17;
            imagenumbers[18] = Properties.Resources.pic18;
            imagenumbers[19] = Properties.Resources.pic19;
            imagenumbers[20] = Properties.Resources.pic20;
            imagenumbers[21] = Properties.Resources.pic21;
            imagenumbers[22] = Properties.Resources.pic22;
            imagenumbers[23] = Properties.Resources.pic23;
            imagenumbers[24] = Properties.Resources.pic24;
            imagenumbers[25] = Properties.Resources.pic25;
            imagenumbers[26] = Properties.Resources.pic26;
            imagenumbers[27] = Properties.Resources.pic27;
            imagenumbers[28] = Properties.Resources.pic28;
            imagenumbers[29] = Properties.Resources.pic29;
            imagenumbers[30] = Properties.Resources.pic30;
            imagenumbers[31] = Properties.Resources.pic31;
            imagenumbers[32] = Properties.Resources.pic32;
            imagenumbers[33] = Properties.Resources.pic33;
            imagenumbers[34] = Properties.Resources.pic34;
            imagenumbers[35] = Properties.Resources.pic35;
            imagenumbers[36] = Properties.Resources.pic36;
            imagenumbers[37] = Properties.Resources.pic00;

        }
        public void results(int winner, string color, string Column, string row, string half, string even, List<string> Winners)
        {
            ColomLabel.Text = "Column: " + Column;
            RowLabel.Text = "Row: " + row;
            HalfLabel.Text = "Half: " + half;
            EvenLabel.Text = "Even/Odd: " + even;
            EvenLabel.Text = "Half: " + color;
            WinningNumberPic.Image = imagenumbers[winner];
            foreach (string name in Winners)
            {
                Winnerlistbox.Items.Add(name);
            }
            LastRound(color);
        }
        private void LastRound(string color)
        {
            switch (color){
                case "Red":
                    LRWinningNumberPic.BackColor = Color.FromArgb(192, 0, 0);
                    break;
                case "Black":
                    LRWinningNumberPic.BackColor = Color.Black;
                    break;
                case "Green":
                    LRWinningNumberPic.BackColor = Color.Green;
                    break;
            }
            LRColom.Text = ColomLabel.Text;
            LRRow.Text = RowLabel.Text;
            LRHalf.Text = HalfLabel.Text;
            LREven.Text = EvenLabel.Text;
            LRWinningNumberPic.Image = WinningNumberPic.Image;
        }

        private void CountDownTimer_Tick(object sender, EventArgs e)
        {
            if (CountDown >= 120)
            {
                CountDownTimer.Stop();
                Tijd.Text = " BETS CLOSED  0:00";
            }
            else
            {
                string seconde;
                CountDown++;
                int huidigtijd = 120 - CountDown;
                int min = huidigtijd / 60;
                int sec = huidigtijd - (60 * min);
                if (sec < 10)
                {
                    seconde = "0" + Convert.ToString(sec);
                }
                else
                {
                    seconde = Convert.ToString(sec);
                }
                string minuut = Convert.ToString(min);
                Tijd.Text = Convert.ToString("  BETS OPEN    " + minuut + ":" + seconde);
            }
        }
    }
}
