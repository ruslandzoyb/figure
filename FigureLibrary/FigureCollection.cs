using FigureLibrary.Abstractions;
using FigureLibrary.ConcreateClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLibrary
{
   public class FigureCollection 
    {
        private Figure[] figures;

        public FigureCollection(Figure[] figures)
        {
            if (figures!=null)
            {
                this.figures = figures;
            }
            else
            {
                throw new NullReferenceException("Figures is null");
            }
        }

        public void SquareInfo()
        {
            foreach (var item in figures)
            {
                Console.WriteLine(item.Square());              

            }
        }

        public static void SquareInfo(Figure figure)
        {
            if (figure!=null)
            {
                Console.WriteLine(figure.Square()); 
            }
        }


    }
}
