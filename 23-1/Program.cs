using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _23_1
{
    internal class Program
    {
        // Overloading

        class Calculator
        {
            public int calc(int num1, int num2)
            {
                return num1 + num2;
            }

            public int calc(int num1, int num2, int num3)
            {
                return num1 + num2 + num3;
            }
            public double calc(double num1, double num2)
            {
                return num1 + num2;
            }

        }


        // Overriding

        class shape
        {
            public virtual void Draw()
            {
                Console.WriteLine("Hi iam draw");
            }
        }

        class Circle : shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a Circle");
            }
        }

        class Rectangular : shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a Rectangle");
            }
        }


        // Abstract Class

        abstract class Animal
        {
            public abstract void makeSound();
            public void sleep()
            {
                Console.WriteLine("Animal is sleeping");
            }
        }

        class Dog : Animal
        {
            public override void makeSound()
            {
                Console.WriteLine("Dog barks");
            }
        }

        class Cat : Animal
        {
            public override void makeSound()
            {
                Console.WriteLine("Cat meows");
            }
        }


        // Interface

        interface IPlayable
        {
            void play();
        }

        class Guitar : IPlayable
        {
            public void play()
            {
                Console.WriteLine("Playing the guitar");
            }
        }

        class Piano : IPlayable
        {
            public void play()
            {
                Console.WriteLine("Playing the piano");
            }
        }

        static void Main(string[] args)
        {

            // Overloading
            Calculator add = new Calculator();
            Console.WriteLine(add.calc(1, 2));
            Console.WriteLine(add.calc(1, 2, 3));
            Console.WriteLine(add.calc(1.1, 2.5));


            // Overriding

            shape shap1 = new Circle();
            shap1.Draw();

            shape shap2 = new Rectangular();
            shap2.Draw();

            // Abstract Class

            Dog dog = new Dog();
            dog.makeSound();

            Cat cat = new Cat();
            cat.makeSound();

            // Interface

            Guitar guitar = new Guitar();
            guitar.play();

            Piano piano = new Piano();
            piano.play();

        }
    }
}
