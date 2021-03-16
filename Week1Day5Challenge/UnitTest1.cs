using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningChallenge
{
    public class user
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        public DateTime DateOfBirth { get; set; }
        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365;
                int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOfAge;
            }

        }
        public user() { }
        public user(string firstName, string lastName, int idNumber, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = idNumber;
            DateOfBirth = dateOfBirth;
        }
    }
}