using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Task_22_1
{
    internal class Program
    {
        //public sealed class Vehicle
        public class Vehicle

        {
            public string Brand { get; set; }
            public string Model { get; set; }

            public void strat()
            {
                Console.WriteLine($"Brand : {Brand}, Model {Model}\n");
            }
        }

        public class Car : Vehicle
        {
            public int NumberOfDoors { get; set; }
        }
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Brand = "Camry";
            myCar.Model = "1";
            myCar.NumberOfDoors = 4;
            myCar.strat();
            

            Vehicle myVehicle = new Vehicle();
            myVehicle.Brand = "Toyota";
            myVehicle.Model = "2";
            myVehicle.strat();
    
        }
    }
}



//What is constructor => make initalize forproberity
//What are the basic concepts of OOPs => Encapsulation, Inheritance, Polymorphism, Abstraction
//What is the Encapsulation => to make the data more private 
//What is the sealed class => prevent Inheritance
//What is the Inheritance concept => to make the child take the same propertiy in parent 