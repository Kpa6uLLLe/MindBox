using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureMeasuring.Interfaces;
namespace FigureMeasuring.Types
{
    public class RegularPolygon : IFigure
    {
        private int _sidesCount;
        private double _side;
        public RegularPolygon(int sidesCount, double side)
        {
            if (side < 0 || sidesCount<0)
                throw new InvalidDataException();
            _sidesCount = sidesCount;
            _side = side;
        }
        public double GetSquare()
        {
            double answer = ((_sidesCount * _side * _side) / (4 * Math.Tan(Math.PI / _sidesCount)));
            return Math.Round(answer,10);
        }
    }
}
