using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace MorningChallenges
{

    public class Calculator
    {

        public int Addition(int a, int b)

        {
            int sum = a + b;
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
            Calculator calculate = new Calculator();

            [TestMethod]
             public void AddMethodReturnTrue()
            {
                
                int sum = calculate.Addition(a, b);
                Assert.AreEqual(sum, (a+b));
                

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
