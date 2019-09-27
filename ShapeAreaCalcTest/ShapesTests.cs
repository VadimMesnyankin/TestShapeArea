using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeAreaCalc;
using ShapeAreaCalc.Shapes;

namespace ShapeAreaCalcTest
{
    [TestClass]
    public class ShapesTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestShapeFactoryCircleIncorrectParameters()
        {
            IShape circle = new ShapeFactory().CreateCircle(0);
        }

        [TestMethod]
        public void TestShapeFactoryCircle()
        {
            IShape circle = new ShapeFactory().CreateCircle(20);
            Assert.IsInstanceOfType(circle, typeof(Circle));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestShapeFactoryTriangleIncorrectParameters()
        {
            IShape triangle = new ShapeFactory().CreateTriangle(10, -1, 3);
        }

        [TestMethod]
        public void TestShapeFactoryTriangle()
        {
            IShape triangle = new ShapeFactory().CreateTriangle(10, 20, 30);
            Assert.IsInstanceOfType(triangle, typeof(Triangle));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTriangleCannotExists()
        {
            new ShapeFactory().CreateTriangle(4, 5, 100).IsRightTriangle();
        }

        [TestMethod]
        public void TestTriangleIsRight()
        {
            Triangle triangle1 = new ShapeFactory().CreateTriangle(4, 5, Math.Sqrt(16 + 25));
            Triangle triangle2 = new ShapeFactory().CreateTriangle(4, 5, 8);
            bool isRight1 = triangle1.IsRightTriangle();
            bool isRight2 = triangle2.IsRightTriangle();
            Assert.IsTrue(isRight1);
            Assert.IsFalse(isRight2);
        }

        [TestMethod]
        public void TestCircleArea()
        {
            double r = 0.123;
            double s = new ShapeAreaCalculator().GetArea(new ShapeFactory().CreateCircle(r));
            Assert.AreEqual(s, Math.PI * Math.Pow(r, 2));
        }

        [TestMethod]
        public void TestTriangleArea()
        {
            double a = 10;
            double b = 11;
            double c = 19;
            double s = new ShapeAreaCalculator().GetArea(new ShapeFactory().CreateTriangle(a, b, c));

            double p = (a + b + c) / 2;
            Assert.AreEqual(s, Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }
    }
}