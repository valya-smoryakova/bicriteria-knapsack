using Knapsack.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Knapsack.Test
{
    [TestClass]
    public class VectorTests
    {
/*
        [TestMethod]
        public void GivenVector_ToString()
        {
            // Arrange (Подготовка)
            Vector a = new Vector(1, 5);
            string expected = "(1, 5)";

            // Act (Действие)
            string actual = a.ToString();

            // Assert (Проверка)
            Assert.AreEqual(expected, actual);
        }
*/
/*
        [TestMethod]
        public void GivenEqualVectors_VectorEquals_ReturnsTrue()
        {
            // Arrange (Подготовка)
            Vector a = new Vector(1, 5);
            Vector b = new Vector(1, 5);

            // Act (Действие)
            bool result = a.Equals(b);

            // Assert (Проверка)
            Assert.IsTrue(result);
        }
*/
/*
        [TestMethod]
        public void GivenNonEqualVectors_VectorEquals_ReturnsFalse()
        {
            // Arrange (Подготовка)
            Vector a = new Vector(1, 5);
            Vector b = new Vector(3, 5);
            
            // Act (Действие)
            bool result = a.Equals(b);

            // Assert (Проверка)
            Assert.IsFalse(result);
        }
*/
/*
        [TestMethod]
        public void GivenEqualVectors_VectorEqualityOperator_ReturnsTrue()
        {
            // Arrange (Подготовка)
            Vector a = new Vector(1, 5);
            Vector b = new Vector(1, 5);

            // Act (Действие)
            bool result = a == b;

            // Assert (Проверка)
            Assert.IsTrue(result);
        }
*/
/*
        [TestMethod]
        public void GivenNonEqualVectors_VectorEqualityOperator_ReturnsFalse()
        {
            // Arrange (Подготовка)
            Vector a = new Vector(1, 5);
            Vector b = new Vector(3, 5);

            // Act (Действие)
            bool result = a == b;

            // Assert (Проверка)
            Assert.IsFalse(result);
        }
*/
/*
        [TestMethod]
        public void GivenEqualVectors_VectorInequalityOperator_ReturnsFalse()
        {
            // Arrange (Подготовка)
            Vector a = new Vector(1, 5);
            Vector b = new Vector(1, 5);

            // Act (Действие)
            bool result = a != b;

            // Assert (Проверка)
            Assert.IsFalse(result);
        }
*/
/*
        [TestMethod]
        public void GivenNonEqualVectors_VectorInequalityOperator_ReturnsTrue()
        {
            // Arrange (Подготовка)
            Vector a = new Vector(1, 5);
            Vector b = new Vector(3, 5);

            // Act (Действие)
            bool result = a != b;

            // Assert (Проверка)
            Assert.IsTrue(result);
        }
*/
/*
        [TestMethod]
        public void Given2Vectors_VectorAddOperator_AddsVectors()
        {
            // Arrange (Подготовка)
            Vector a = new Vector(1, 64);
            Vector b = new Vector(3, 5);

            // Act (Действие)
            Vector result = a + b;

            // Assert (Проверка)
            Assert.AreEqual(new Vector(4, 69), result);
        }
*/
/*
        [TestMethod]
        public void Given2Vectors_VectorMinusOperator_SubstractsVectors()
        {
            // Arrange (Подготовка)
            Vector a = new Vector(1, 64);
            Vector b = new Vector(3, 5);

            // Act (Действие)
            Vector result = a - b;

            // Assert (Проверка)
            Assert.AreEqual(new Vector(-2, 59), result);
        }
*/
/*
        [TestMethod]
        public void GivenVectorCanBeComparedVaryByBothComponents_VectorCompare_ReturnsBetterAndWorse()
        {
            // Arrange (Подготовка)
            Vector a = new Vector(6, 7);
            Vector b = new Vector(3, 5);

            // Act (Действие)
            ComparisonResult result1 = a.Compare(b);
            ComparisonResult result2 = b.Compare(a);

            // Assert (Проверка)
            Assert.AreEqual(ComparisonResult.Better, result1);
            Assert.AreEqual(ComparisonResult.Worse, result2);
        }
*/
/*
        [TestMethod]
        public void GivenVectorCanBeComparedVaryBy1stComponent_VectorCompare_ReturnsBetterAndWorse()
        {
            // Arrange (Подготовка)
            Vector a = new Vector(6, 7);
            Vector b = new Vector(3, 7);

            // Act (Действие)
            ComparisonResult result1 = a.Compare(b);
            ComparisonResult result2 = b.Compare(a);

            // Assert (Проверка)
            Assert.AreEqual(ComparisonResult.Better, result1);
            Assert.AreEqual(ComparisonResult.Worse, result2);
        }
*/
/*
        [TestMethod]
        public void GivenVectorCanBeComparedVaryBy2ndComponent_VectorCompare_ReturnsBetterAndWorse()
        {
            // Arrange (Подготовка)
            Vector a = new Vector(6, 7);
            Vector b = new Vector(6, 5);

            // Act (Действие)
            ComparisonResult result1 = a.Compare(b);
            ComparisonResult result2 = b.Compare(a);

            // Assert (Проверка)
            Assert.AreEqual(ComparisonResult.Better, result1);
            Assert.AreEqual(ComparisonResult.Worse, result2);
        }
*/
/*
        [TestMethod]
        public void GivenVectorCanNotBeCompared_VectorCompare_ReturnsNotComparable()
        {
            // Arrange (Подготовка)
            Vector a = new Vector(6, 4);
            Vector b = new Vector(3, 5);

            // Act (Действие)
            ComparisonResult result1 = a.Compare(b);
            ComparisonResult result2 = b.Compare(a);

            // Assert (Проверка)
            Assert.AreEqual(ComparisonResult.NotComparable, result1);
            Assert.AreEqual(ComparisonResult.NotComparable, result2);
        }
*/
/*
        [TestMethod]
        public void GivenEqualVectors_VectorCompare_ReturnsNotComparable()
        {
            // Arrange (Подготовка)
            Vector a = new Vector(6, 4);
            Vector b = new Vector(6, 4);

            // Act (Действие)
            ComparisonResult result = a.Compare(b);

            // Assert (Проверка)
            Assert.AreEqual(ComparisonResult.NotComparable, result);
        }
*/
    }
}