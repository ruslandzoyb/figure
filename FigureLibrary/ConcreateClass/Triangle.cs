using FigureLibrary.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLibrary.ConcreateClass
{
    public class Triangle : Figure
    {
        private double sideA, sideB, sideC;
        public double Half 
        { get => Perimeter() / 2; }
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA>0&&sideB>0&&sideC>0)
            {
                this.sideA = sideA;
                this.sideB = sideB;
                this.sideC = sideC;
            }
            else
            {
                throw new ArgumentException("Value is smaller or equal 0");
            }

        }

        public override double Perimeter()
        {
            return sideA + sideB + sideC;
        }

        public override double Square()
        {
            return Math.Sqrt(Half * (Half - sideA) * (Half - sideB) * (Half - sideC));
        }
    }
}
