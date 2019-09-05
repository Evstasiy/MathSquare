using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathSquare.Shapes;
using MathSquare;

namespace MathSquare.Test {
    [TestClass]
    public class MathSquareUnitTest {
        [TestMethod]
        public void CircleSquareNegetive_Test() {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(-1));
        }
        [TestMethod]
        public void TriangleSquareNegetive_Test() {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-1, 0, 0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(0, -1, 0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(0, 0, -1));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-1, -1, -1));
        }
        [TestMethod]
        public void RectangleSquareNegetive_Test() {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Rectangle(-1, 0, 0, 0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Rectangle(0, -1, 0, 0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Rectangle(0, 0, -1, 0));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Rectangle(0, 0, 0, -1));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Rectangle(-1, -1, -1, -1));
        }
        [TestMethod]
        public void TriangleRectangular_Test() {
            Triangle tri = new Triangle(5, 12, 13);
            Assert.AreEqual(true,tri.isRectangular);
        }
        [TestMethod]
        public void TriangleNotRectangular_Test() {
            Triangle tri = new Triangle(1, 2, 3);
            Assert.AreEqual(false, tri.isRectangular);
        }
        [TestMethod]
        public void CircleSquare_Test() {
            double radius = 1;

            double expected = Math.PI * Math.Pow(radius, 2);
            double actual = new Circle(radius).GetSquare();

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void RectangleSquare_Test() {
            double a = 2,
                b = 2,
                c = 3,
                d = 3;

            double expected = a*b*c*d;
            double actual = new Rectangle(a,b,c,d).GetSquare();
            Assert.AreEqual(expected, actual);
        }
    }
}
