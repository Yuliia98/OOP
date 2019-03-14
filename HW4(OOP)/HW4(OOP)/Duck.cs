using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_OOP_
{
    class Duck :Animal,IFlying
    {
        public Duck(string name, double weight, int age)
            : base(name, weight, age)
        { }

        public override void Eat()
        {
            Console.WriteLine($"Duck {Name} eat grass");
        }
        public void Fly()
        {
            Console.WriteLine($"{Name} weight {Weight} kg but he can fly :)");
        }

        public override string ToString()
        {
            return "Duck - " + base.ToString();
        }
    }
}
