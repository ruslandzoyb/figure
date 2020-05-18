using FigureLibrary.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLibrary.ConcreateClass
{
   public class SquareF:Figure
    {
        protected double side;

        public SquareF(double side)
        {
            if (side>0)
            {
                this.side = side;
            }
            else
            {
                throw new ArgumentException("Value is equal or smaller than 0");
            }
        }

        public override double Perimeter()
        {
            return 4 * side;
        }

        public override double Square()
        {
            return Math.Pow(side, 2);
        }
    }
}
