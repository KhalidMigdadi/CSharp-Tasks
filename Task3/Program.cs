using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        // Q1 
        static void oddEvenCheck()
        {
            Console.Write("Enter Number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            if (userNumber % 2 == 0)
            {
                Console.WriteLine("The number " + userNumber + " is Even");
            }
            else
                Console.WriteLine("The number " + userNumber + " is Odd");

        }


        // Q2

        //static void secondSmallest()
        //{
            //Console.WriteLine("Write 5 numbers: ");
        //    int userNumber = Convert.ToInt32(Console.ReadLine());

        //    int[] numbers = new int[userNumber]; // Declare an array of the specified size

        //    int small1 = int.MaxValue;
        //    int small2 = int.MaxValue;

        //    for (int i = 0; i < userNumber; i++)
        //    {
        //        Console.Write($"Element {i + 1}: ");
        //        numbers[i] = Convert.ToInt32(Console.ReadLine()); // Read and store each element
        //    }

        //    //string userNumber = Console.ReadLine();
        //    foreach (int i in numbers)
        //    {
        //        if (i < small1)
        //        {
        //            small2 = small1;
        //            small1 = i;
        //        }
        //        else if (i < small2 && i != small1)
        //        {
        //            small2 = i;
        //        }

        //    }


        //}

        // Q3
        static void factorial()
        {
            Console.WriteLine("Enter Number to chek factorial");
            int userNumber = Convert.ToInt32(Console.Read());
            int factorial = 1;

            for (int i = 1; i <= userNumber; i++)
            {
                factorial *= i;

            }
            Console.WriteLine(userNumber);
        }


        // Q4

        static void prime()
        {
            Console.Write("Enter the first number: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Prime numbers between {start} and {end} are:");

            for (int num = start; num <= end; num++)
            {
                bool isPrime = true;


                if (num < 2)
                    isPrime = false;
                else
                {
                    for (int i = 2; i <= Math.Sqrt(num); i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                    Console.Write($"{num} ");
            }



        }


        // Q5

        //static void largest()

        //{
        //    Console.WriteLine("Enter Some Numbers to check which is the largest number: ");
        //    int Numbers = Convert.ToInt32(Console.ReadLine());

        //    int[] numbers = new int[Numbers];

        //    for (int i = 0; i < 10; i++)
        //    {
        //        //Console.Write("element - {0} : ", i);  // Prompt for input element number
        //        numbers[i] = Convert.ToInt32(Console.ReadLine());  // Read user input and convert it to an integer, then store in the array
        //    }

        //    Array.Sort(numbers);


        //    Console.WriteLine(numbers[numbers.Length-1]);


        //}


        static void largest()
        {
            Console.WriteLine("Enter the number of elements to check which is the largest number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());  // Getting the number of elements

            int[] numbers = new int[userNumber];  // Create an array of that size

            // Loop to accept input for each number
            for (int i = 0; i < userNumber; i++)
            {
                Console.WriteLine($"Enter number {i + 1}: ");  // Prompt for input
                numbers[i] = Convert.ToInt32(Console.ReadLine());  // Read user input and store in the array
            }

            // Sort the array
            Array.Sort(numbers);

            // Print the largest number (last element after sorting)
            Console.WriteLine($"The largest number is: {numbers[numbers.Length - 1]}");
        }


        // Q6 

        static void pattern()
        {
            // let x =0;
            // for(let i = 1; i < 9; i++){
            //     x = x + i +" " 
            //     console.log(x); 
            // }
            //int x = 0;
            //for (int i = 1; i < 16; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {

            //    }
            //}

            //Console.WriteLine("Enter Numbers:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write(new string(' ', n - i));
            //    Console.WriteLine(new string('*', 2 * i - 1));
            //}



            int n = 5, count = 1;

            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= i; j++)
                {

                    Console.Write(count++ + " ");

                }
                Console.WriteLine();
            }


        }



        class Room
        {
            public int RoomNumber;
            public string RoomType;
            public double PricePerNight;
            public bool IsBooked;

            public const string HotelName = "Grand Stay Hotel";

            public void PrintRoomDetails()
            {
                Console.WriteLine($"Hotel Name: {HotelName}");
                Console.WriteLine($"Room Number: {RoomNumber}");
                Console.WriteLine($"Room Type: {RoomType}");
                Console.WriteLine($"Price Per Night: {PricePerNight:C}");
                Console.WriteLine($"Booked: {(IsBooked ? "Yes" : "No")}");
                Console.WriteLine();
            }
        }



        static void Main(string[] args)
        {
            // Q1 
            //Write a C# program that accepts an integer and determines if the number is even or odd. Display the result
            oddEvenCheck();


            // Q2
            // Write a C# program that accepts five numbers and displays the  2nd smallest of the five.
            //secondSmallest();

            // Q3
            // Write a program that calculates the factorial of a given number using a for loop
            factorial();

            // Q4
            // Write a program that takes two integers as input and prints all the prime numbers between them using nested loops
            prime();

            // Q5
            // Create a program that initializes an integer array and finds the largest number in it using a foreach loop.
            largest();

            // Q6
            // Write a program that prints the following number pattern using nested loops: For n = 5, the output should be:

            //1
            //2 3
            //4 5 6
            //7 8 9 10
            //11 12 13 14 15

            pattern();




            //bool isPrime = true;

            //int x = 25;
            //for (int i = 2; i < x; i++)
            //{
            //    if (x % i == 0)
            //    {
            //        isPrime = false;
            //        Console.Write(" Prime");
            //        break;
            //    }


            //    if (isPrime)
            //    {
            //        Console.Write("Not Prime");
            //        break;
            //    }

            //}




    }
    }
}
