using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalcClassBr;

namespace CulcTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMult_ValidValues()
        {
            // Тест множення в межах int
            long a = 20000;
            long b = 30000;
            int expected = 20000 * 30000;

            // Виклик методу Mult з класу CalcClass
            int result = CalcClass.Mult(a, b);

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMult_InvalidValues()
        {
            // Тест множення в межах int
            long a = 20000;
            long b = 30000;
            int expected = 20000 * 30000;

            // Виклик методу Mult з класу CalcClass
            int result = CalcClass.Mult(a, b);

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMult_OutOfRangeInput()
        {
            // Тест, коли одне з значень виходить за межі int
            long a = (long)int.MaxValue + 1;
            long b = 2;

            // Виклик методу Mult з класу CalcClass
            CalcClass.Mult(a, b);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMult_OutOfRangeResult()
        {
            // Тест, коли результат множення виходить за межі int
            long a = int.MaxValue;
            long b = 2;

            // Виклик методу Mult з класу CalcClass
            CalcClass.Mult(a, b);
        }

        [TestMethod]
        public void TestMult_ValidEdgeCase()
        {
            // Тест на граничних значеннях
            long a = int.MaxValue;
            long b = 1;
            int expected = int.MaxValue;

            // Виклик методу Mult з класу CalcClass
            int result = CalcClass.Mult(a, b);

            Assert.AreEqual(expected, result);
        }



    }
}


