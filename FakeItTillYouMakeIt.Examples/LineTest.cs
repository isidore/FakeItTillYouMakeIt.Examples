using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FakeItTillYouMakeIt.Examples
{
    [TestClass]
    public class LineTest
    {
        [TestMethod]
        public void TestHorizontalLength2()
        {
            var line = new Line(0, 0, 2, 0);
            Assert.AreEqual(2, line.Length);
        }

        [TestMethod]
        public void TestHorizontalLength4()
        {
            var line = new Line(0, 0, 4, 0);
            Assert.AreEqual(4, line.Length);
        }

        [TestMethod]
        public void TestVerticalLength4()
        {
            var line = new Line(0, 0, 0, 4);
            Assert.AreEqual(4, line.Length);
        }
    }

    public class Line
    {
        private readonly int x1;
        private readonly int y1;
        private readonly int x2;
        private readonly int y2;

        public Line(int x1, int y1, int x2, int
            y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public int Length
        {
            get
            {
                var x = x2 - x1;
                var y = y2 - y1;
                return x + y;
            }
        }
    }
}