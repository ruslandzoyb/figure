using FigureLibrary.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLibrary.ConcreateClass
{
   public class Round:Figure
    {
        private double r;
        public Round(double r)
        {
            if (r>0)
            {
                this.r = r;
            }
            else
            {
                throw new ArgumentException("Value is equal or smaller than 0");
            }
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * r;
        }

        public override double Square()
        {
            return Math.PI * Math.Pow(r, 2);
        }
    }
}
