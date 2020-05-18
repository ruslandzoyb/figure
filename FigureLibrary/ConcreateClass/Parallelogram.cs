using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace FigureLibrary.ConcreateClass
{
   public class Parallelogram :Rectangle
    {
        private double h;

        public Parallelogram(double sideA,double sideB, double h):base(sideA,sideB)
        {
            if (h>0)
            {
                this.h = h;
            }
            else
            {
                throw new ArgumentException("Value is equal or smaller than 0");
            }
        }
        public override double Square()
        {
            return sideA * h;
        }


    }
}
