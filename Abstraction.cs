using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS___Async_Await
{
    internal class Abstraction : AbstractExample
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Test");
        }
    }

    abstract class AbstractExample
    {
        public abstract void AnimalSound();

        public void Print()
        {
            Console.WriteLine("Hii");
        }
    }
}
