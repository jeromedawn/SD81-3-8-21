using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ValueTypes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;
            isDeclared = true;

            bool isDeclaredAndInitialized = false;

            isDeclaredAndInitialized = true;
        }
        [TestMethod]

        public void Characters()
        {
            char character = 'a';
            char symbol = '?';
            char numbers = '7';
            char space = ' ';
            char specialCharacter = '\n';
        }

        [TestMethod]

        public void WholeNumbers()
        {
            byte byteExample = 255;
            sbyte sByteExmple = 127;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = 2147483647;
            Int32 intMax = 2147483647;
            long longExample = 92337203;
            Int64 longMin = 92337203;

            int a = 15;
            int b = -15;

            byte age = 25;
        }

        [TestMethod]

        public void Deciamls()
        {
            float floatExample = 1.045231f;
            double doubleExample = 1.789053278907036d;
            decimal decimalExample = 1.2578907289045789789789789787897m;

            Console.WriteLine(1.2578907289045789789789789787897f);
            Console.WriteLine(1.2578907289045789789789789787897d);
            Console.WriteLine(1.2578907289045789789789789787897m);

        }

        enum PastryType { cake, cupcake, eclaire, petitfour, croissant}
        [TestMethod]

        public void Enums()
        {
            PastryType myPastry = PastryType.croissant;
            PastryType anotherOne = PastryType.cake;
        }
        [TestMethod]

        public void Structs()
        {
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(1995, 7, 18);

            Console.WriteLine(today);
        }

    }
}
