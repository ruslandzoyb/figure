using FigureLibrary.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLibrary.ConcreateClass
{
   public class Trapeze:Figure
    {
        private double sideA, sideB, sideC, sideD;
        public double H { 
            get 
            {
                return Math.Sqrt(((-sideA + sideB + sideC + sideD) * (sideA - sideB + sideC + sideD) * (sideA - sideB + sideC - sideD) * (sideA - sideB - sideC + sideD)) / (2 * Math.Abs(sideB - sideA)));
            } 
        }
        public Trapeze(double sideA, double sideB, double sideC, double sideD)
        {
            if (sideA>0&& sideB > 0 && sideC > 0 && sideD > 0)
            {
                this.sideA = sideA;
                this.sideB = sideB;
                this.sideC = sideC;
                this.sideD = sideD;
            }
            else
            {
                throw new ArgumentException("Value is equal or smaller than 0");
            }
        }

        public override double Perimeter()
        {
            return sideA + sideB + sideC + sideD;
        }

        /// <summary>
        /// Fix 
        /// </summary>
        /// <returns></returns>
        public override double Square()
        {
            return ((sideA + sideB) / 2) * H;
        }
    }
}
