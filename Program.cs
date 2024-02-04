using System;
using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace OOPS___Async_Await
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Synchronous Programming

            //To demonstarate synchronous programming
            //Result : Methods will get execute according to their calling sequence.
            //Output : 
            //StartExecution
            //MidExecution
            //EndExecution
            //Total Execution Time 18056


            //Sync sync = new Sync();
            //sync.Main();

            #endregion

            #region Asynchronous Programming

            //To demonstarate asynchronous  programming
            //Result : At first, the method which require less time will get executed.
            //Output :
            //MidExecution
            //EndExecution
            //StartExecution
            //Total Execution Time 8023

            //Async async = new Async();
            //async.Main();

            #endregion

            #region OOPS

            #region 1) Inheritance

            //To demonstrate Inheritance 
            //Result : Child class "Car" inherits fields and methods from base class "Vehicle"
            //Output :
            //Tata Motors
            //Tata Punch
            //Pom Pom

            //Inheritance inheritance = new Inheritance();
            //inheritance.DisplayInheritance();

            #endregion

            #region 2) Polymorphism

            //To demonstrate Polymorphism
            //Polymorphism is an ability to exist in multiple forms, Have two types :
            //1) Compile time polymorphism : Also known as static polymorphism and can be achived by Method Overloading

            //Polymorphism polymorphism = new Polymorphism();

            //Result : Two methods named as "Add" but they differ in number of parameters also they acn differ in return type.
            //Output : 
            //Sum of 20 + 30 + 40 = 90
            //Sum of 20 + 30 = 50

            //polymorphism.Display_MethodOverloading();

            //2) Run time polymorphism : Also known as dynamic polymorphism and  acn be achieved by Method Overriding
            //Result : Same method "AnimalSound" is override in their respective derived classes.
            //Output :
            //I'm an Animal
            //I'm Cat
            //I'm Dog

            //polymorphism.Display_MethodOverriding();

            #endregion

            #region 3) Abstraction

            //To demonstrate Abstraction
            //Abstarction is showing only essential information and hiding certain details.
            //Result : The members inside the abstract class can be only access if its inherited in another class
            //Output :
            //Test
            //Hii

            //Abstraction abstraction = new Abstraction();

            //abstraction.AnimalSound();
            //abstraction.Print();

            #endregion

            #region Encapsulation 

            //To demonstrate Encapsulation
            //Encapsulation is wrapping up the data and information under a single unit.
            //Result : The "name" private property of Info class can be accessed through public property "studentName". 
            //Output : 
            //Suyog Vasage

            //Encapsulation encapsulation = new Encapsulation();
            //encapsulation.Main();

            #endregion

            #endregion

            Console.ReadLine();
        }
    }
}