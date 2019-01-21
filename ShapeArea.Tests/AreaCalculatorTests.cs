using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// ReSharper disable ParameterOnlyUsedForPreconditionCheck.Local

namespace ShapeArea.Tests
{
    [TestClass]
    public class AreaCalculatorTests
    {
        [TestMethod]
        public void CalculateNegativeCircleAreaTest()
        {
            double area = AreaCalculator.CalculateCircleArea(-1.0);
            Assert.IsTrue(double.IsNaN(area));
        }

        [TestMethod]
        public void CalculateZeroCircleAreaTest()
        {
            CheckCircle(0.0, 0.0);
        }

        [TestMethod]
        public void CalculateCircleAreaTest()
        {
            CheckCircle(1.0, Math.PI);
        }

        [TestMethod]
        public void CalculateNegativeTriangleAreaTest()
        {
            CheckTriangleNan(-1.0, 1.0, 1.0);
        }

        [TestMethod]
        public void CalculateNotATriangleAreaTest()
        {
            CheckTriangleNan(10.0, 1.0, 1.0);
        }

        [TestMethod]
        public void CalculateRightAngledTriangleAreaTest()
        {
            CheckTriangle(3.0, 4.0, 5.0, 6.0);
        }

        [TestMethod]
        public void CalculateTriangleAreaTest()
        {
            CheckTriangle(3.0, 3.0, 4.0, Math.Sqrt(20.0));
        }

        private static void CheckTriangle(double side1, double side2, double side3, double expected)
        {
            double area = AreaCalculator.CalculateTriangleArea(side1, side2, side3);
            Assert.IsFalse(double.IsNaN(area));
            AssertKindaEqual(expected, area);

            area = AreaCalculator.CalculateTriangleArea(side1, side3, side2);
            Assert.IsFalse(double.IsNaN(area));
            AssertKindaEqual(expected, area);

            area = AreaCalculator.CalculateTriangleArea(side2, side1, side3);
            Assert.IsFalse(double.IsNaN(area));
            AssertKindaEqual(expected, area);

            area = AreaCalculator.CalculateTriangleArea(side2, side3, side1);
            Assert.IsFalse(double.IsNaN(area));
            AssertKindaEqual(expected, area);

            area = AreaCalculator.CalculateTriangleArea(side3, side1, side2);
            Assert.IsFalse(double.IsNaN(area));
            AssertKindaEqual(expected, area);

            area = AreaCalculator.CalculateTriangleArea(side3, side2, side1);
            Assert.IsFalse(double.IsNaN(area));
            AssertKindaEqual(expected, area);
        }

        private static void CheckTriangleNan(double side1, double side2, double side3)
        {
            double area = AreaCalculator.CalculateTriangleArea(side1, side2, side3);
            Assert.IsTrue(double.IsNaN(area));

            area = AreaCalculator.CalculateTriangleArea(side1, side3, side2);
            Assert.IsTrue(double.IsNaN(area));

            area = AreaCalculator.CalculateTriangleArea(side2, side1, side3);
            Assert.IsTrue(double.IsNaN(area));

            area = AreaCalculator.CalculateTriangleArea(side2, side3, side1);
            Assert.IsTrue(double.IsNaN(area));

            area = AreaCalculator.CalculateTriangleArea(side3, side1, side2);
            Assert.IsTrue(double.IsNaN(area));

            area = AreaCalculator.CalculateTriangleArea(side3, side2, side1);
            Assert.IsTrue(double.IsNaN(area));
        }

        private static void CheckCircle(double radius, double expected)
        {
            double actual = AreaCalculator.CalculateCircleArea(radius);
            Assert.IsFalse(double.IsNaN(actual));
            AssertKindaEqual(expected, actual);
        }

        private static void AssertKindaEqual(double expected, double actual)
        {
            Assert.IsTrue(Math.Abs(expected - actual) <= double.Epsilon);
        }
    }
}