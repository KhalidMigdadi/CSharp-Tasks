using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_4_21_1
{

    class Student
    {
        public string name { get; set; }
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= MinAge && value <= MaxAge)
                {
                    this.age = value;
                }
                else
                {
                    this.age = 0;
                }

            }
        }

        //private int Id;
        //public int studentID {
        //    get
        //    {
        //        return Id;
        //    }
        //    set
        //    {
        //        if (value < 1)
        //            Id = 1;
        //        else Id= value;
        //    }
        //}


        public int studentID { get; set; }
        public string Email{ get; set; }
        public const int MinAge = 18;
        public const int MaxAge = 40;


        // constructor 


        public Student()
        {
            name = "";
            age = 1;
            studentID = 0;
            Email = "";
        }
        public Student(string name, int age, int studentID, string Email)
        {
            this.name = name;
            this.Age = age;
            this.studentID = studentID;
            this.Email= Email;
        }

        public void GetDetails()
        {
            Console.WriteLine($"The Name : {name}\nThe Age: {age}\nThe Studen ID : {studentID}");
        }

       

        ~Student() 
        {
            Console.WriteLine("We Finish the object");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student();
            std1.name = "Ahmad";
            std1.Age = 9;
            std1.studentID = 1001;

            std1.GetDetails();

            Student std2 = new Student("Khalid", 9, 1000, "kmgdadi@gmail.com");
            std2.GetDetails(); // Display details of second student



            // What is class ? => template or blueprint used to define the structure and behavior of objects
            // What is object? => instance of a class
            // Difference between class && object => class is container for objects 
            // Mention the OOP Principles => Encapsulation, Abstraction, Inheritance, Polymorphism
            // What is property => field but has get and set 
            // What is field => variable in class 
            // What is constructor => make initial value for the property 
            // What is encapsulation => make the data more private 


        }
    }
}
