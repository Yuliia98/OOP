using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_OOP_
{
    class Straus : Animal
    {
        public Straus(string name, double weight, int age)
            : base(name, weight, age)
        { }

        public override void Eat()
        {
            Console.WriteLine($"Straus {Name} eat grass and hay");
        }

        public override string ToString()
        {
            return "Straus - " + base.ToString();
        }
    }
}
