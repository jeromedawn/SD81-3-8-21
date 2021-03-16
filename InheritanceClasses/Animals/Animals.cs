using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InheritanceClasses
{
    public enum DietType { Herbivore = 1 , Carnivore, Omnivore}
  
    public class Animals
    {

        public Animals()
        {
            Console.WriteLine("This is animal constructor.");
        }

        public string AnimalName { get; set; }
        public int NumberOfLegs { get; set; }
        public bool IsMammal { get; set; }
        public bool HasFur { get; set; }
        public DietType DietType { get; set; }

        public virtual void Move()
        {
            Console.WriteLine($"This {GetType().Name} moves.");
        }


    }
}
