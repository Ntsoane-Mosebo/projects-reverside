using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercises
{

    class Program
    {

        public int FindMax(int x, int y, int z)
        {

            int high = 0;
            if (x > high)
                high = x;
            if (y > high)
                high = y;
            if (z > high)
                high = z;
            return high;
        }

        public int FindSecLargest(int x, int y, int z)
        {
            int slargest = 0;
            if ((x > y && y > z) || (z > y && y > x))
            {
                slargest = y;
            }

            else if ((y > z && z > x) || (x > z && z > y))// (y > x && x > z)
            {
                slargest = z;
            }

            else if ((z > x && x > y) || (y > x && x > z))
            {
                slargest = x;
            }

            return slargest;
        }

        public int FindMaxInSevenNumbers(int[] arr)
        {

            int highest = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {


                if (highest < arr[i])
                {
                    highest = arr[i];
                }

            }
            return highest;
        }

        public void Fizzbuzz(int number)
        {

            for (int i = 1; i <= number; i++)
            {

                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else if (i % 3 != 0 && i % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FIZZBUZZ");
                }
                else Console.WriteLine(i);

            }
        }
            public void FindingPositive(int number) {

            if (number == 0)
            {
                Console.Write("The number {0} is zero ", number);
            }
            else if (number > 0)
            {

                Console.Write("The number {0} is positive number ", number);
            }
            else
                Console.Write("The number {0} is negative number ", number);
        }

        public void FindOdd(int number) {

            if (number % 2 == 0)
            {

                Console.Write("The number {0} is even ", number);
            }
            else
                Console.Write("The number {0} is odd ", number);

        }
        public void CheckingLeapYear(int year) {

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {

                Console.WriteLine("the year is a leap year" + year);
            }
            else
                Console.WriteLine("the year is not a leap year: " + year);

        }

    }
        class ProgramTest
        {
            static void Main(string[] args)
            {

                Program p = new Program();

           //Finding  largest number among 3 numbers
              Console.WriteLine("Finding  largest number among 3 numbers");
              Console.WriteLine("Enter three numbers to check largest");
              int x = Convert.ToInt32(Console.ReadLine());
              int y = Convert.ToInt32(Console.ReadLine());
              int z = Convert.ToInt32(Console.ReadLine());

              int high = p.FindMax(x, y, z);
              Console.WriteLine(" largest is:" + high);

              Console.WriteLine("========================================");
              Console.WriteLine("Finding  second largest number among 3 numbers");
              int slargest = p.FindSecLargest(x, y, z);
              Console.WriteLine("second largest is :" + slargest);
              Console.WriteLine("========================================");

              Console.WriteLine("Finding  largest number among 7 numbers");

              int[] arr = new int[7];
              Console.WriteLine("Enter seven numbers");
              for (int i = 0; i < arr.Length; i++)
              {
                  arr[i] = Convert.ToInt32(Console.ReadLine());
              }
              Console.WriteLine(" largest is:" + p.FindMaxInSevenNumbers(arr));
              Console.WriteLine("========================================");


              Console.WriteLine("Priting fizz,buzz or fizzbuzz provided conditions");
              Console.WriteLine("Enter the number");
              int number = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Entered number is" + number);
              p.Fizzbuzz(number);

              Console.WriteLine("========================================");
              Console.WriteLine("checking if number is positive,negative or zero");
              Console.WriteLine("Enter the number");
              int num = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Entered number is " + number);
                p.FindingPositive( num);
                

            Console.WriteLine("========================================");
            Console.WriteLine("Enter the number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entered number is" + number1);
            p.FindOdd(number);



            Console.WriteLine("========================================");
            Console.WriteLine("Enter the year you want to check");
            int year = Convert.ToInt32(Console.ReadLine());

            p.CheckingLeapYear( year );
        }
        }
    }

