using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechRoulette
{
    class Forms
    {
        private Form1 form1;
        private Form2 form2;

        private bool IsForm2;
        public Forms ()
        {
            IsForm2 = false;
        }
        public void AddForm(Form1 form)
        {
            form1 = form;
        }
        public void AddForm(Form2 form)
        {
            form2 = form;
            IsForm2 = true;
        }
        public void Refresh(bool inzetfase, List<string> Top10)
        {
            if (IsForm2 == true && inzetfase == true)
            {
                form2.ConvertTop10(Top10);
            }
            else if (IsForm2 == true && inzetfase == false)
            {
                form2.Nobets();
            }
        }
        public void Result(Number number)
        {
            string WinName = number.spaceName;
            if (WinName == "00")
            {
                WinName = "37";
            }
            int Winner = Convert.ToInt16(WinName);
            string WinColumn = number.spaceColumn;
            string WinEven = number.spaceEven;
            string WinHalf = number.spaceHalf;
            string WinRowSet = number.spaceRowSet;
            string WinColor = number.spaceColor;
            string Column; string Row; string Half; string Even;
            switch (WinColumn)
            {
                case "Column1": Column = "1st 12";
                    break;
                case "Column2": Column = "2nd 12";
                    break;
                case "Column3": Column = "3rd 12";
                    break;
                default: Column = "No Winner";
                    break;
            }
            switch (WinRowSet)
            {
                case "Rowset1": Row = "1st 2 To 1";
                    break;
                case "Rowset2": Row = "2nd 2 To 1";
                    break;
                case "Rowset3": Row = "3rd 2 To 1";
                    break;
                default:Row = "No Winner";
                    break;
            }
            switch (WinHalf)
            {
                case "Half1": Half = "1 To 18";
                    break;
                case "Half2": Half = "19 To 36";
                    break;
                default: Half = "No Winner";
                    break;
            }
            switch (WinEven)
            {
                case "Odd": Even = "Odd";
                    break;
                case "Even": Even = "Even";
                    break;
                default: Even = "No Winner";
                    break;
            }       
            form2.results(Winner, WinColor, Column, Row, Half, Even, form1.Payout(Winner, WinColor, WinColumn, WinRowSet, WinHalf, WinEven));
        }

        public void Start()
        {
            form2.Start();
        }

        public void GameData(List<string> list)
        {
            form2.GameData(list);
        }
    }
}
