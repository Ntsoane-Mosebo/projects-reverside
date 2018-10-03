using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationExcersise
{
    class Program
    {
        public int FindLargest(int[] arr)
        {
            int high = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (high < arr[i])
                {
                    high = arr[i];
                }

            }
            return high;
        }
        public int FindSlargest(int[] arr)
        {

            int secondhigh = 0;
            int high = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] > high)
                {
                    secondhigh = high;
                    high = arr[i];

                }
                else if (arr[i] > secondhigh)
                {
                    secondhigh = arr[i];
                }

            }
            return secondhigh;
        }
        public void IsAvailable(int[] arr)
        {
            Console.WriteLine("Enter number checked");
            int checkedNo = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (checkedNo == arr[i])
                {

                    Console.WriteLine("number {0} checked is available in the array", checkedNo);

                    break;
                }
                else

                    Console.WriteLine("number {0} checked is not available at this  array index", checkedNo);
            }

        }

        public int NumberOfOccurrence(int[] arr, int item)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {

                if (item == arr[i])
                {
                    count++;
                }

            }
            return count;
        }

        public int CountWords(string str)
        {

            int count = 0;
            int i = 0, L = 1;
            string str1;

            while (i <= str.Length - 1)
            {
                if (str[i] == ' ' || str[i] == '\n' || str[i] == '\t')
                {

                    L++;
                }
                i++;
            }
            return L;

        }

        public int NoOfSpaces(string str)
        {

            int count = 0;
            string str1;
            for (int i = 0; i < str.Length; i++)
            {
                str1 = str.Substring(i, 1);
                if (str1 == " ")
                    count++;


            }
            return count;
        }

        public string StringReversal(string str)
        {
            int length;
            string revstr = "";
            length = str.Length - 1;

            while (length >= 0)
            {
                revstr = revstr + str[length];
                length--;

            }
            return revstr;
        }

        public int NumberOfDigits(int number)
        {
            int length = 1;
            while ((number /= 10) > 1)
                length++;
            return length;
        }

        public int SumOfDigits(int number)
        {

            int sum = 0;
            while (number != 0)
            {

                sum = sum + number % 10;
                number = number / 10;
            }
            return sum;
        }
        public int SumOfOddDigits(int number)
        {

            int sum = 0;
            for (int i = 1; i <= number; i++)
            {


                if (i % 2 != 0)
                {
                    sum = sum + i;
                }

            }
            return sum;
        }

        public void FibonacciSeries(int length)
        {

            int num1 = 1;
            int num2 = 2;
            int num3;
            for (int i = 3; i <= length; i++)
            {

                num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
            }

        }
        public void PrintEvenNos(int[] arr)
        {
            Console.Write("even number are: ");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {


                    Console.WriteLine(" \n" + arr[i]);

                }

            }
        }

        public void SortArray(int[] arr)
        {

            int temp;
        
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                
                    }

                   
                }
                Console.Write(" " + arr[i]);
            }
      }

        public   int FindFrequentNo(int[]array) {

            int count = 1, tempCount;
            int frequentNumber = array[0];
            int tempNumber = 0;
            for (int i = 0; i < (array.Length - 1); i++)
            {
                tempNumber = array[i];
                tempCount = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (tempNumber == array[j])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    frequentNumber = tempNumber;
                    count = tempCount;
                   
                }
            }
           
           
            return frequentNumber;
        }

        public void SwappingFirstLast(int number) {

            int num1= 0;
            int num2 = 1;


            while (number>9) {

                num1 += num2 * 10 * (number % 10);
                number /= 10;
                num1 += num2 * (number % 10);
                number /= 10;
                num2 *= 100;
            }
            Console.WriteLine(num1);
        }
        public int FindMaxDifference(int[] arr) {
            int diff = 0;
            int maxDiff = 0;
            for (int i=0;i<arr.Length-1;i++) {
                diff = arr[i + 1] - arr[i];

                if (diff>maxDiff) {
                    maxDiff = diff;
                }
            }


            return maxDiff; }

        public int IntegerReverse(int num)
        {
            string intAsString = num.ToString();
            int Length = intAsString.Length - 1;
            string reversedString = " ";

            while (Length >= 0)
            {
                reversedString = reversedString + intAsString[Length];
                Length--;

            }
            return Int32.Parse(reversedString);
            

        }

        public string IsVowel(char alphabet) {

           
        
            switch (alphabet)
            {
                case 'A':
                case 'a':
                case 'E':
                case 'e':
                case 'I':
                case 'i':
                case 'O':
                case 'o':
                case 'U':
                case 'u':
                    {
                        return "Vowel";
                    }
                default:
                    {
                        return "Consonent";
                    }
            
        }

    }

        public int StringConversion(string num) {

            
            int parsednum = int.Parse(num);
            int number = parsednum;


            return number;
        }
        public void ReplaceWithDash(string str) {
            string str1 = str.Replace(' ','_');
            Console.WriteLine(str1);

        }

    }


    class ProgramTest
    {
        static void Main(string[] args)
        {
            Program p = new Program();

          Console.WriteLine("Finding largest number from an array of numbers");
             Console.WriteLine("Enter the size of an array");
             int length = Convert.ToInt16(Console.ReadLine());
             int[] arr = new int[length];
             Console.WriteLine("Enter elements in an array");
             for (int i = 0; i < arr.Length; i++) {
                 arr[i] = Convert.ToInt16(Console.ReadLine());
                     }
             int high = p.FindLargest(arr);
             Console.WriteLine("the highest number is : {0}",high);
             Console.WriteLine("================================================================");

             Console.WriteLine("Finding second largest number from an array of numbers");
             int secondhighest = p.FindSlargest(arr);
             Console.WriteLine("the second highest number is : {0}", secondhighest);
             Console.WriteLine("================================================================");

    
            Console.WriteLine("Finding if a number is present in an array of numbers");
            Console.WriteLine("Enter number of values you want to input");
            int number = Convert.ToInt16(Console.ReadLine());
           
            Console.WriteLine("Entered  numbers in an array");
            int[] arr1 = new int[number];
            for (int i = 0; i < number; i++)
            {
                arr1[i] = Convert.ToInt16(Console.ReadLine());

            }
            p.IsAvailable(arr1);
            Console.WriteLine("================================================================");

            Console.WriteLine("Finding  number of occurrences of a number in an array of numbers");

            Console.WriteLine("Enter number of values you want to input");
             number = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter  numbers in an array");
            int[] arr2 = new int[number];
           
            for (int i = 0; i < number; i++)
            {
                arr2[i] = Convert.ToInt16(Console.ReadLine());

            }

            Console.WriteLine("Enter Item want to check its occurence number");
            int item = Convert.ToInt16(Console.ReadLine());


            int count = p.NumberOfOccurrence(arr2,item);
            
            Console.WriteLine("the number of occurence of {0} is {1}", item, count);
          

          Console.WriteLine("================================================================");
                Console.WriteLine("Find number of words in a sentence");
               Console.WriteLine("Write you sentence ");
              string  str = Convert.ToString(Console.ReadLine());
                count = p.CountWords(str);
               Console.WriteLine("there are {0} words", count);


            Console.WriteLine("================================================================");
            Console.WriteLine("Finding number of spaces in a sentence");
            Console.WriteLine("Write you sentence ");
             str = Convert.ToString(Console.ReadLine());
             count = p.NoOfSpaces(str);
            Console.WriteLine("there are {0} spaces ", count);
           
   
            Console.WriteLine("================================================================");
            Console.WriteLine("Reverse a string");
            Console.WriteLine(" enter a string");
             str = Convert.ToString(Console.ReadLine());
            string revstr = p.StringReversal(str);

            Console.WriteLine(" reversed string is:" + revstr);


            Console.WriteLine("================================================================");
            Console.WriteLine("Counting number of digits in a number");

            Console.Write("Enter the number ");
             number = Convert.ToInt32(Console.ReadLine());
            length = p.NumberOfDigits(number);
            Console.WriteLine("length is " + length); 

            Console.WriteLine("================================================================");
            Console.WriteLine("Calculating sum of digits in a number");

            Console.Write("Enter the number ");
            number = Convert.ToInt32(Console.ReadLine());
            int sum = p.SumOfDigits(number);
            Console.WriteLine("sum is " + sum);

            Console.WriteLine("================================================================");
            Console.WriteLine("Finding sum of all odd numbers between 1 to N");

            Console.WriteLine("Enter a number want to sum to");
              number = Convert.ToInt16(Console.ReadLine());
             sum = p.SumOfOddDigits(number);
            Console.WriteLine("there are {0} odd numbers", sum);

   
             Console.WriteLine("================================================================");
            Console.WriteLine("Generating fibonacci series from 1 to N");

            Console.WriteLine("Enter the length");
            int num1 = 1, num2 = 2;
            length = Convert.ToInt16(Console.ReadLine());
            Console.Write(num1 + " " + num2 + " ");
            p.FibonacciSeries(length); 

            Console.WriteLine("================================================================");
            Console.WriteLine("Finding all even numbers from an array of numbers");


            Console.WriteLine("Enter number of values you want to input");
            number = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Entered  numbers in an array");
            int[] arr3 = new int[number];
            for (int i = 0; i < number; i++)
            {
                arr3[i] = Convert.ToInt16(Console.ReadLine());

            }

          p.PrintEvenNos(arr3);

            Console.WriteLine("================================================================");
            Console.WriteLine("Finding all even numbers from an array of numbers");


            Console.WriteLine("Enter number of values you want to input");
             number = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Entered  numbers in an array");
            int[] arr4 = new int[number];
            for (int i = 0; i < number; i++)
            {
                arr4[i] = Convert.ToInt16(Console.ReadLine());

            }
            p.SortArray(arr4);
    
            Console.WriteLine("================================================================");
            Console.WriteLine("Finding the number in an array of numbers with maximum occurrences");
            Console.WriteLine("Enter number of values you want to input");
            number = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Entered  numbers in an array");
            int[] arr5 = new int[number];
            for (int i = 0; i < number; i++)
            {
                arr5[i] = Convert.ToInt16(Console.ReadLine());

            }
            int frequentNumber = p.FindFrequentNo(arr5);
             count = p.FindFrequentNo(arr5);
            Console.WriteLine("The most frequent number in this array is {0} :", frequentNumber);

            Console.WriteLine("================================================================");
            Console.WriteLine("Swap first & last digit of a number");

            Console.WriteLine("Enter number of values you want to input");
             number = Convert.ToInt16(Console.ReadLine());
            
          p.SwappingFirstLast(number);
           
            Console.WriteLine("================================================================");
            Console.WriteLine("Find the maximum difference between two consecutive items in an array of numbers");

           
            Console.WriteLine("Enter number of values you want to input");
             number = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Entered  numbers in an array");
             int[]arr6 = new int[number];
            for (int i = 0; i < number; i++)
            {
                arr6[i] = Convert.ToInt16(Console.ReadLine());

            }
            int maxDiff = p.FindMaxDifference(arr6);

            Console.WriteLine("Maximum difference is"+maxDiff);
        
            //Console.WriteLine("================================================================");
            //Console.WriteLine("Reverse a number");



             Console.WriteLine("================================================================");
              Console.WriteLine("Find the maximum difference between two consecutive items in an array of numbers");

              Console.WriteLine("Enter the alphabet");
              char alphabet = Convert.ToChar(Console.ReadLine());
              Console.WriteLine("Alphabet is a {0}",p.IsVowel(alphabet));


              Console.WriteLine("================================================================");
              Console.WriteLine("Reverse a number");
              Console.WriteLine("Enter the a number");
              number = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine(" Reversed number is "+p.IntegerReverse(number));

              Console.WriteLine("================================================================");
              Console.WriteLine("Convert numeric string value to number");
              Console.WriteLine("Enter the a string number");
              string num = Convert.ToString(Console.ReadLine());
              int x= p.StringConversion(num);
              Console.WriteLine(" uncoded number is " + x);



              Console.WriteLine("================================================================");
              Console.WriteLine("Replace all spaces in a sentence with underscore");
              Console.WriteLine("Enter the a string number");
               str= Convert.ToString(Console.ReadLine());
              p.ReplaceWithDash(str);
             

        }
    }
}
