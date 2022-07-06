using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class RegularPolyTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NewPolyNegativeSides()
        {
            double side = -5;
            int sides = 4;
            Assert.Catch<InvalidDataException>(() => new FigureMeasuring.Types.RegularPolygon(sides, side));
        }
        [Test]
        public void Rectangle5()
        {
            double side = 5;
            int sides = 4;
            FigureMeasuring.Types.RegularPolygon regularPolygon = new FigureMeasuring.Types.RegularPolygon(sides, side);
            double expected = 25;
            double actual = regularPolygon.GetSquare();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Pentagon5()
        {
            double side = 5;
            int sides = 5;
            FigureMeasuring.Types.RegularPolygon regularPolygon = new FigureMeasuring.Types.RegularPolygon(sides, side);
            double expected = 43.0119350147;
            double actual = regularPolygon.GetSquare();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Octangle5()
        {
            double side = 5;
            int sides = 8;
            FigureMeasuring.Types.RegularPolygon regularPolygon = new FigureMeasuring.Types.RegularPolygon(sides, side);
            double expected = 120.7106781187;
            double actual = regularPolygon.GetSquare();
            Assert.AreEqual(expected, actual);
        }
    }
}
