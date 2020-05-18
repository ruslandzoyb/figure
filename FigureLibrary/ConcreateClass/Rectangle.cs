using FigureLibrary.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLibrary.ConcreateClass
{
    public class Rectangle : Figure
    {
        protected double sideA, sideB;
        public Rectangle(double sideA,double sideB)
        {
            if (sideA>0&&sideB>0)
            {
                this.sideA = sideA;
                this.sideB = sideB;
            }
            else
            {
                throw new ArgumentException("Value is smaller or equal  0");
            }
        }


        public override double Perimeter()
        {
            return 2 * (sideA + sideB);           
        }

        public override double Square()
        {
            return sideA * sideB;
        }
    }
}
