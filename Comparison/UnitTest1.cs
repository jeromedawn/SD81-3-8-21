using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Comparison
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComparisonCharacters()
        {
            int age = 25;
            string userName = "Mick";

            bool equals = age == 41;
            Console.WriteLine(equals);

            bool userIsJerome = userName == "Jerome";

            Console.WriteLine(userIsJerome);

            bool notEqual = age != 122;
            Console.WriteLine($"User is not 122: {notEqual}");

            bool userNameIsNotJerome = userName != "Jerome";
            Console.WriteLine(userNameIsNotJerome);

            List<string> firstList = new List<string>();
            firstList.Add(userName);
            

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            //Compare the List 
            bool listAreEqual = firstList == secondList;
            Console.WriteLine($"The list are equal?:{listAreEqual}");

            //greater than
            bool greaterThan = age > 12;
            Console.WriteLine(greaterThan);

            //greater than or equal to
            bool greaterThanEqualTo = age >= 12;
            Console.WriteLine(greaterThanEqualTo);

            //less than 
            bool lessThan = age < 66;
            Console.WriteLine(lessThan);

            //less than or equal
            bool lessThanEqualTo = age <= 24;
            Console.WriteLine(lessThanEqualTo);

            bool orValue = equals || lessThan;

            bool trueValue = true;
            bool falseValue = false;

            bool tOrT = trueValue || trueValue;
            bool tOrF = trueValue || falseValue;
            bool fOrT = falseValue|| trueValue;
            bool fOrF = falseValue|| falseValue;

            Console.WriteLine($"True or True {tOrT}");
            Console.WriteLine($"True or False {tOrF}");
            Console.WriteLine($"False or True {fOrT}");
            Console.WriteLine($"False or False {fOrF}");

            // and &&

            bool andValue = greaterThan && orValue;

            bool tAndT = trueValue && trueValue;
            bool tAndF = trueValue && falseValue;
            bool fAndT = falseValue && trueValue;
            bool fAndF = falseValue && falseValue;

            Console.WriteLine($"True and True {tAndT}");
            Console.WriteLine($"True and False {tAndF}");
            Console.WriteLine($"False and True {fAndT}");
            Console.WriteLine($"False and False {fAndF}");

        }
    }
}
