using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Arithmetic
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SimpleOperators()
        {
            int a = 22;
            int b = 15;

            //Addition

            int sum = a + b;

            //Shorthand Addition 
            sum += 3;
            Console.WriteLine($"sum:{sum}");

            //Subtraction 

            int difference = a - b;
            Console.WriteLine($"difference:{difference}");

            //Multiplication & Division 

            int product = a * b;
            Console.WriteLine($"product:{product}");

            int division = a / b;
            Console.WriteLine($"division:{division}");

            //Modulus 

            int remainder = a % b;
            Console.WriteLine($"remainder:{ remainder}");

            DateTime now = DateTime.Now;
            DateTime someday = new DateTime(2022, 3, 9);


            TimeSpan timeSpan = now - someday;
            Console.WriteLine(timeSpan);
            Console.WriteLine(timeSpan.Days);
            Console.WriteLine(timeSpan.TotalMilliseconds);

        }
    }
}
