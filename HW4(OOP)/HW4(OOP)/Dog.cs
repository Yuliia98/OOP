using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_OOP_
{
    class Dog : Animal, IBarking
    {
        public Dog(string name, double weight, int age)
            : base(name, weight, age)
        { }

        public override void Eat()
        {
            Console.WriteLine($"Dog {Name} eat meat");
        }
        public void Bark()
        {
            Console.WriteLine($"{Name} is {Age} years old but he still can bark :/");
        }

        public override string ToString()
        {
            return "Dog - " + base.ToString();
        }
    }
}
