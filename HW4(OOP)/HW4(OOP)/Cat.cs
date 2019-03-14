using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_OOP_
{
    class Cat : Animal, IMeowing
    {
        public Cat(string name, double weight, int age)
            : base(name, weight, age)
        { }

        public override void Eat()
        {
            Console.WriteLine($"Cat {Name} eat fishes");
        }
        public void Meow()
        {
            Console.WriteLine($"{Name} can meow ^_^");
        }

        public override string ToString()
        {
            return "Cat - " + base.ToString();
        }
    }
}
