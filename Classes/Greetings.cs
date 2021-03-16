using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Greetings
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }

        Random _random = new Random();
        public void GetRandomGreetings()
        {
            string[] avaialbeGreetings = new string[] { "Good morning", "Hey", "What's up", "hello" };
            int randomNumber = _random.Next(0, avaialbeGreetings.Length);
            string randomGreeting = avaialbeGreetings.ElementAt(randomNumber);
            Console.WriteLine($"{randomGreeting}");
        }
    }
} 
