using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechRoulette
{
    public class Number
    {
        public string spaceName { get; }
        public string spaceColor { get; }
        public string spaceColumn { get; }
        public string spaceRowSet { get; }
        public string spaceHalf { get; }
        public string spaceEven { get; }

         public Number(string spaceName, string spaceRowSet, string spaceEven, string spaceHalf, string spaceColumn, string spaceColor)
        {
            this.spaceName = spaceName;
            this.spaceColumn = spaceColumn;
            this.spaceEven = spaceEven;
            this.spaceHalf = spaceHalf;
            this.spaceRowSet = spaceRowSet;
            this.spaceColor = spaceColor;
        } 
    }
}