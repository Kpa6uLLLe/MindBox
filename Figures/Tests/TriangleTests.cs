namespace Tests
{
    public class TriangleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetSquareTest5_5_5()
        {
            double[] array = { 5, 5, 5 };
            double expected = Math.Round(10.825317547305483, 10);
            FigureMeasuring.Types.Triangle triangle = new FigureMeasuring.Types.Triangle(array);
            double actual = triangle.GetSquare();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void NewTriangleTest4sides()
        {
            double[] array = { 5, 5, 5, 5 };
            Assert.Catch<InvalidDataException>(() => new FigureMeasuring.Types.Triangle(array));
        }
        [Test]
        public void NewTriangleTest2sides()
        {
            double[] array = { 5, 5};
            Assert.Catch<InvalidDataException>(() => new FigureMeasuring.Types.Triangle(array));
        }
        [Test]
        public void NewTriangleTestNegativeSide()
        {
            double[] array = { 5, -5, 5 };
            Assert.Catch<InvalidDataException>(() => new FigureMeasuring.Types.Triangle(array));
        }
        [Test]
        public void IsRectangularTest5_5_5()
        {
            double[] array = { 5, 5, 5 };
            bool expected = false;
            FigureMeasuring.Types.Triangle triangle = new FigureMeasuring.Types.Triangle(array);
            bool actual = triangle.IsRectangular();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void IsRectangularTest5_4_3()
        {
            double[] array = { 5, 4, 3 };
            bool expected = true;
            FigureMeasuring.Types.Triangle triangle = new FigureMeasuring.Types.Triangle(array);
            bool actual = triangle.IsRectangular();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void IsRectangularTest10_8_6()
        {
            double[] array = { 10, 8, 6 };
            bool expected = true;
            FigureMeasuring.Types.Triangle triangle = new FigureMeasuring.Types.Triangle(array);
            bool actual = triangle.IsRectangular();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void IsRectangularTest8_10_6()
        {
            double[] array = { 8, 10, 6 };
            bool expected = true;
            FigureMeasuring.Types.Triangle triangle = new FigureMeasuring.Types.Triangle(array);
            bool actual = triangle.IsRectangular();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void IsRectangularTest6_10_8()
        {
            double[] array = { 6, 10, 8 };
            bool expected = true;
            FigureMeasuring.Types.Triangle triangle = new FigureMeasuring.Types.Triangle(array);
            bool actual = triangle.IsRectangular();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetSquareTest6_10_8()
        {
            double[] array = { 6, 10, 8 };
            double expected = (6*8)/2;
            FigureMeasuring.Types.Triangle triangle = new FigureMeasuring.Types.Triangle(array);
            double actual = triangle.GetSquare();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetSquareTest600_1000_800()
        {
            double[] array = { 600, 1000, 800 };
            double expected = (600 * 800) / 2;
            FigureMeasuring.Types.Triangle triangle = new FigureMeasuring.Types.Triangle(array);
            double actual = triangle.GetSquare();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetSquareTest0_5__0_4__0_3()
        {
            double[] array = { 0.5, 0.4, 0.3 };
            double expected = 0.4 * 0.3 / 2;
            expected = Math.Round(expected, 10);
            FigureMeasuring.Types.Triangle triangle = new FigureMeasuring.Types.Triangle(array);
            double actual = triangle.GetSquare();
            Assert.AreEqual(expected, actual);
        }

    }
}