using FigureLibrary.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLibrary.ConcreateClass
{
   public class Rhomb :SquareF
    {
        private double d1, d2;
        public Rhomb(double side,double d1,double d2):base(side)
        {
            if (d1>0&&d2>0)
            {
                this.d1 = d1;
                this.d2 = d2;
            }
            else
            {
                throw new ArgumentException("Value is equal or smaller than 0");
            }
           
        }
        public override double Square()
        {
            return (d1 * d2) / 2;
        }
    }
}
