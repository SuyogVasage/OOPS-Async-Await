using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS___Async_Await
{
    internal class Polymorphism
    {
        public void Display_MethodOverloading()
        {
            int a = 20;
            int b = 30;
            int c = 40;

            Console.WriteLine($"Sum of {a} + {b} + {c} = {Add(a, b, c)}");
            Console.WriteLine($"Sum of {a} + {b} = {Add(a, b)}");
        }

        public void Display_MethodOverriding()
        {
            Animal animal = new Animal();
            Cat cat = new Cat();
            Dog dog = new Dog();

            animal.AnimalSound();
            cat.AnimalSound();
            dog.AnimalSound();
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    public class Animal
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("I'm an Animal");
        }

    }

    public class Cat : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("I'm Cat");
        }
    }

    public class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("I'm Dog");
        }
    }
}
