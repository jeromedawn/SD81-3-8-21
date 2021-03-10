using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatements()
        {
            bool userIsHungry = true;
            if (userIsHungry)
            {
                Console.WriteLine("Eat Something");

            }

            int hoursStudying = 1;
            if (hoursStudying < 16) ;
            {
                Console.WriteLine("You're not trying");
            }
        }
        [TestMethod]

        public void IfElseStatements()
        {
            bool choresAreDone = false;
             if (choresAreDone)
            {
                Console.WriteLine("Have fun");

            }
             else
            {
                Console.WriteLine("Stay home");
            }

            // Turning String into Int 

            string input = "2";
            int totalHours = int.Parse(input);

            if(totalHours >= 8)
            {
                Console.WriteLine("Well Rested");
            }
            else
            {
                Console.WriteLine("Gonna be tired");
                if(totalHours< 4 )
                Console.WriteLine("Get more sleep");
            }

            int age = 32;
            if (age > 17)
            {
                Console.WriteLine("adult");
            }
            else
            {
                if (age > 6)
                {
                    Console.WriteLine("Kid");
                }
                else if (age > 0)
                {
                    Console.WriteLine("too young for PC");
                }
                else
                {
                    Console.WriteLine("You're not born yet");
                }
            }

            if(age <65 && age >18)
            {
                Console.WriteLine("Age is between 18 and 65");
            }

            if (age > 65 || age < 18)
            {
                Console.WriteLine("Age is greater than 65 or less than 18");
            }

            if (age  == 21)
            {
                Console.WriteLine("Age is equal to 21");
            }

            if (age != 36)
            {
                Console.WriteLine("Age is not equal to 36");
            }


        }
    }
}
