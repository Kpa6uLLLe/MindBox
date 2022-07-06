using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class CircleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NewCircleNegativeRadius()
        {
            double radius = -5;
            Assert.Catch<InvalidDataException>(() => new FigureMeasuring.Types.Circle(radius));
        }
        [Test]
        public void GetSquareRadius_1()
        {
            double radius = 1;
            double expected = System.Math.PI;
            FigureMeasuring.Types.Circle circle = new FigureMeasuring.Types.Circle(radius);
            double actual = circle.GetSquare();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetSquareRadius_2()
        {
            double radius = 2;
            double expected = System.Math.PI*4;
            FigureMeasuring.Types.Circle circle = new FigureMeasuring.Types.Circle(radius);
            double actual = circle.GetSquare();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetSquareRadius_1000()
        {
            double radius = 1000;
            double expected = System.Math.PI*1000000;
            FigureMeasuring.Types.Circle circle = new FigureMeasuring.Types.Circle(radius);
            double actual = circle.GetSquare();
            Assert.AreEqual(expected, actual);
        }
    }
}