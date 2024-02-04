using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOPS___Async_Await
{
    internal class Inheritance
    {
        public void DisplayInheritance()
        {
            Car car = new Car();
            Console.WriteLine(car.brand);
            Console.WriteLine(car.carName);
            car.Horn();
        }
    }

    public class Vehicle
    {
        public string brand = "Tata Motors";

        public void Horn ()
        {
            Console.WriteLine("Pom Pom");
        }
    }

    public class Car : Vehicle 
    {
        public string carName = "Tata Punch";
    }
}
