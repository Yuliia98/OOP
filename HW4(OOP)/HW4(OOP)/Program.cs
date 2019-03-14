using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_OOP_
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Cat cat = new Cat("Vasya", 3.5, 2);
                Dog dog = new Dog("Tobik", 5, 3);
                Straus straus = new Straus("Tosha", 6.5, 4);
                Duck duck = new Duck("Donald", 2.3, 1);

                cat.Eat();
                dog.Eat();
                straus.Eat();
                duck.Eat();
                cat.Meow();
                dog.Bark();
                duck.Fly();
                Console.WriteLine("\nInformation about animals:");
                Console.WriteLine(cat);
                Console.WriteLine(dog);
                Console.WriteLine(straus);
                Console.WriteLine(duck);
                Console.ReadKey();
            
        }
    }
}
