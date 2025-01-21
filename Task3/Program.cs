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

        static void secondSmallest()
        {
            Console.Write("Enter 5 numebrs to check witch is the samll one\n");
            int[] numebrs = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter Number {i + 1}: ");
                int userNumber = int.Parse(Console.ReadLine());
                numebrs[i] = userNumber;
            }
            Array.Sort(numebrs);
            Console.WriteLine($"The second smallest number is: {numebrs[1]}");


        }

        // Q3
        static void factorial()
        {
            Console.Write("Enter Number to check factorial : ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            //for (int i = 1; i <= userNumber; i++)
            //{

            //    factorial = factorial * i;
            //}
            //Console.WriteLine(factorial);

            for (int i = userNumber; i > 0; i--)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);

        }


        // Q4

        static void prime()
        {

            Console.WriteLine("Enter 2 Numbers to get all the prime numbers between them");
            Console.Write("Enter Number 1: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter Number 2 : ");
            int end = int.Parse(Console.ReadLine());


            for (int i = start; i <= end; i++)
            {
                bool isPrime = true;
                if (i < 2)
                {
                    isPrime = false;
                    break;
                }
                else
                {
                    // for loop for the numbers that will i divide the userNumber to
                    for (int j = 2; j <= start; j++)
                    {
                        //if (j % i == 0)
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }

                    }

                }
                if (isPrime)
                    Console.Write($"{i} ");

            }


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


        // Q5

        static void largest()
        {
            Console.WriteLine("How many size of the array u want ?");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter Number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);
            Console.WriteLine($"The Largest number is : {numbers[numbers.Length - 1]}");

        }


        // Q6 

        static void pattern()
        {

            int count = 1;
            for (int i = 1; i < 6; i++) // X-axis
            {
                for (int j = 1; j <= i; j++) // Y-axis
                {

                    Console.Write(count++ + " ");

                }
                Console.WriteLine();

            }


        }


        // Q8
        static void sumEvenOdd()
        {
            Console.Write("How Many Numbers Did u want to enter ? ");
            int number = int.Parse(Console.ReadLine());

            int[] numbers = new int[number];
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < number; i++)
            {
                Console.Write($"Enter Number {i + 1}: ");
                int nums = int.Parse(Console.ReadLine());
                numbers[i] = nums;

                if (numbers[i] % 2 == 0)
                {
                    evenSum += numbers[i];
                }
                else
                {
                    oddSum += numbers[i];

                }

            }


            Console.WriteLine($"Sum Of Even Numbers are : {evenSum}");
            Console.WriteLine($"Sum Of Odd Numbers are : {oddSum}");
        }

        // Q9
        static void same()
        {

            int[] nums1 = new int[4];
            int[] nums2 = new int[4];


            Console.WriteLine("Enter 4 Numbers on 2 Groups to print the common one");

            Console.WriteLine("Enter 4 Numbers in Group 1");
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Enter Number ({i + 1}) from Group1 : ");
                int num1 = int.Parse(Console.ReadLine());
                nums1[i] = num1;
            }

            Console.WriteLine("Enter 4 Numbers in Group 2 : ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Enter Number ({i + 1}) from Group2 : ");
                int num2 = int.Parse(Console.ReadLine());
                nums2[i] = num2;
            }


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++) // to comapre each num from array1 to all element in array2
                {
                    if (nums1[i] == nums2[j])
                    {
                        Console.WriteLine(nums1[i]);
                        break; // Avoid printing duplicates from the same group
                    }
                }
            }

        }


        class Hotel
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
            //oddEvenCheck();


            // Q2
            // Write a C# program that accepts five numbers and displays the  2nd smallest of the five.
            //secondSmallest();

            // Q3
            // Write a program that calculates the factorial of a given number using a for loop
            //factorial();

            // Q4
            // Write a program that takes two integers as input and prints all the prime numbers between them using nested loops
            //prime();


            // Q5
            // Create a program that initializes an integer array and finds the largest number in it using a foreach loop.
            //largest();



            // Q6
            // Write a program that prints the following number pattern using nested loops: For n = 5, the output should be:

            //1
            //2 3
            //4 5 6
            //7 8 9 10
            //11 12 13 14 15

            //pattern();


            // Q7
            // Write a program that prints a pyramid pattern using stars (*) based on the input height.Use nested loops. (optional

            //   *
            //  ***
            // *****
            //*******


            //Console.Write("Enter pyramid height:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write(new string(' ', n - i));
            //    Console.WriteLine(new string('*', 2 * i - 1));
            //}

            // Q8
            //Write a program that takes an array of integers and calculates the sum of even numbers and odd numbers separately using loops.  (optional)
            //sumEvenOdd();

            //Q9
            // Write a program that compares two arrays and prints their common elements using loops. (optional)

            //same();

            // classes

            Hotel room = new Hotel();
            room.RoomNumber = 1;
            room.RoomType = "Single";
            room.PricePerNight = 10;
            room.IsBooked = true;
            room.PrintRoomDetails();





        }
    }
}
