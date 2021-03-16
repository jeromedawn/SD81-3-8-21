
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace Week2Day2Challenge
{

    public class Calculator
    {

        public int Addition(int a, int b)

        {
            int sum = a + b;
            return sum;
        }

        public double DoubleAddition(double c, double d)
        {
            double sum = c + d;
            return sum;
        }

        public int Subtraction(int a, int b)
        {
            int num = a - b;
            return num;
        }

        public int Multiplication(int a, int b)
        {
            int product = a * b;
            return product;
        }

        public int Division(int a, int b)
        {
            int quotient = a / b;
            return quotient;
        }
        [TestClass]
        public class CalculatorTestClass
        {
            private int a = 10;
            private int b = 5;
            private double c = 10.5;
            private double d = 11.5;
            Calculator calculate = new Calculator();

            [TestMethod]
            public void AddMethodReturnTrue()
            {

                var sum = calculate.Addition(a, b);
                var sumOne = calculate.DoubleAddition(c, d);

                var testSum = a + b;
                var testSumOne = c + d;


                Assert.AreEqual(sum, testSum);
                Assert.AreEqual(sumOne, testSumOne);

                Console.WriteLine(sum);
                Console.WriteLine(testSum);
                Console.WriteLine(sumOne);
                Console.WriteLine(testSumOne);


            }
            public void SubMethodReturnTrue()
            {
                Calculator calculate = new Calculator();
                int num = calculate.Subtraction(a, b);
                Assert.AreEqual(num, (a - b));
            }

        }


    }
}
