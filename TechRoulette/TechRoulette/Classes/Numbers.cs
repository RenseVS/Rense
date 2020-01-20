using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRoulette
{
    public class Numbers
    {
        private readonly List<Number> NumbersList = new List<Number>();
        public Numbers()
        {
            AddNumbers();
        }
        private void AddNumbers()
        {
            NumbersList.Add(new Number("0", "0", "0", "0", "0", "Green"));
            NumbersList.Add(new Number("1", "Rowset1", "Odd", "Half1", "Column1", "Red"));
            NumbersList.Add(new Number("2", "Rowset2", "Even", "Half1", "Column1", "Black"));
            NumbersList.Add(new Number("3", "Rowset3", "Odd", "Half1", "Column1", "Red"));
            NumbersList.Add(new Number("4", "Rowset1", "Even", "Half1", "Column1", "Black"));
            NumbersList.Add(new Number("5", "Rowset2", "Odd", "Half1", "Column1", "Red"));
            NumbersList.Add(new Number("6", "Rowset3", "Even", "Half1", "Column1", "Black"));
            NumbersList.Add(new Number("7", "Rowset1", "Odd", "Half1", "Column1", "Red"));
            NumbersList.Add(new Number("8", "Rowset2", "Even", "Half1", "Column1", "Black"));
            NumbersList.Add(new Number("9", "Rowset3", "Odd", "Half1", "Column1", "Red"));
            NumbersList.Add(new Number("10", "Rowset1", "Even", "Half1", "Column1", "Black"));
            NumbersList.Add(new Number("11", "Rowset2", "Odd", "Half1", "Column1", "Black"));
            NumbersList.Add(new Number("12", "Rowset3", "Even", "Half1", "Column1", "Red"));
            NumbersList.Add(new Number("13", "Rowset1", "Odd", "Half1", "Column2", "Black"));
            NumbersList.Add(new Number("14", "Rowset2", "Even", "Half1", "Column2", "Red"));
            NumbersList.Add(new Number("15", "Rowset3", "Odd", "Half1", "Column2", "Black"));
            NumbersList.Add(new Number("16", "Rowset1", "Even", "Half1", "Column2", "Red"));
            NumbersList.Add(new Number("17", "Rowset2", "Odd", "Half1", "Column2", "Black"));
            NumbersList.Add(new Number("18", "Rowset3", "Even", "Half1", "Column2", "Red"));
            NumbersList.Add(new Number("19", "Rowset1", "Odd", "Half2", "Column2", "Red"));
            NumbersList.Add(new Number("20", "Rowset2", "Even", "Half2", "Column2", "Black"));
            NumbersList.Add(new Number("21", "Rowset3", "Odd", "Half2", "Column2", "Red"));
            NumbersList.Add(new Number("22", "Rowset1", "Even", "Half2", "Column2", "Black"));
            NumbersList.Add(new Number("23", "Rowset2", "Odd", "Half2", "Column2", "Red"));
            NumbersList.Add(new Number("24", "Rowset3", "Even", "Half2", "Column2", "Black"));
            NumbersList.Add(new Number("25", "Rowset1", "Odd", "Half2", "Column3", "Red"));
            NumbersList.Add(new Number("26", "Rowset2", "Even", "Half2", "Column3", "Black"));
            NumbersList.Add(new Number("27", "Rowset3", "Odd", "Half2", "Column3", "Red"));
            NumbersList.Add(new Number("28", "Rowset1", "Even", "Half2", "Column3", "Black"));
            NumbersList.Add(new Number("29", "Rowset2", "Odd", "Half2", "Column3", "Black"));
            NumbersList.Add(new Number("30", "Rowset3", "Even", "Half2", "Column3", "Red"));
            NumbersList.Add(new Number("31", "Rowset1", "Odd", "Half2", "Column3", "Black"));
            NumbersList.Add(new Number("32", "Rowset2", "Even", "Half2", "Column3", "Red"));
            NumbersList.Add(new Number("33", "Rowset3", "Odd", "Half2", "Column3", "Black"));
            NumbersList.Add(new Number("34", "Rowset1", "Even", "Half2", "Column3", "Red"));
            NumbersList.Add(new Number("35", "Rowset2", "Odd", "Half2", "Column3", "Black"));
            NumbersList.Add(new Number("36", "Rowset3", "Even", "Half2", "Column3", "Red"));
            NumbersList.Add(new Number("00", "0", "0", "0", "0", "Green"));
        }

        public Number Resultaten(int Input)
        {
            return NumbersList[Input];
        }
    }

}