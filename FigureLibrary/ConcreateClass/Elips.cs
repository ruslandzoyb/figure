using FigureLibrary.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLibrary.ConcreateClass
{
   public class Elips:Figure
    {
        private double a, b;
        public Elips(double a,double b)
        {
            if (a>0&&b>0)
            {
                this.a = a;
                this.b = b;
            }
            else
            {
                throw new ArgumentException("Value is equal or smaller than 0");
            }
        }

        /// <summary>
        /// Fix
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return 4 * ((Square() * Math.Pow(a - b, 2)) / (a + b));
        }

        public override double Square()
        {
            return Math.PI * a * b;
        }
    }
}
