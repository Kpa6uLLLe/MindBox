using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureMeasuring.Interfaces;
namespace FigureMeasuring.Types
{
    public class Circle : IFigure
    {
        private double radius;
        public Circle(double radius)
        {
            if (radius < 0)
                throw new InvalidDataException();
            this.radius = radius;

        }
        public double GetSquare()
        {
            //PI*r^2
            return Math.PI * radius * radius;
        }
    }
}
