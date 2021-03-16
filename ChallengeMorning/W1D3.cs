using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MorningChallenge
{
    [TestClass]
    public class MorningChallenge1
    {
        [TestMethod]
        public void WeekOneDayThree()
        {
            string MarryPoppinsPhrase = "Supercalifragilisticexpialidocious";

            foreach (char letter in MarryPoppinsPhrase)
            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }


            string MarryPoppinsPhrase1 = "Supercalifragilisticexpialidocious";

            foreach (char letter in MarryPoppinsPhrase1)
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else if (letter == 'l')
                {
                    Console.WriteLine("L");
                }
                else
                {
                    Console.WriteLine("not an I");
                }





            }


        }



    }
}

