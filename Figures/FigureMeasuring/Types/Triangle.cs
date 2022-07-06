using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureMeasuring.Interfaces;
namespace FigureMeasuring.Types
{
    public class Triangle : IFigure
    {
        private double[] _sides = new double[3];

        public Triangle(double[] sides)
        {
            if(sides.Min() < 0 || sides.Length!=3)
                    throw new InvalidDataException();
            this._sides = sides;
        }

        public double GetSquare()
        {
            //sqrt(p/2*(p/2-a)*(p/2-b)*(p/2-c)), где p - периметр
            double halfPerimeter = (_sides[0] + _sides[1] + _sides[2])/2;
            double answer = Math.Sqrt(halfPerimeter * (halfPerimeter - _sides[0]) * (halfPerimeter - _sides[1]) * (halfPerimeter - _sides[2]));
            return Math.Round(answer,10);
            
        }

        public bool IsRectangular()
        {
            List<double> sortedSides = _sides.OrderBy(x => x).ToList();
            for (int i = 0; i < sortedSides.Count; i++)
                sortedSides[i] *= sortedSides[i]; 
            return (sortedSides[2] == (sortedSides[1] + sortedSides[0]));
        }
    }
}
