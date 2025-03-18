using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExerciesePart3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* -------------------------- 1. Array Initialization & Output -------------------*/

            //int[] numbers = {5, 6, 7, 4, 1};

            //for (int i=0; i<numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            /* -------------------------- 2. Find Maximum & Minimum in an Array  -------------------*/

            //int x;
            //int[] numbers = new int[10];

            //Console.WriteLine("Enter 10 Numbers");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    x = int.Parse(Console.ReadLine());
            //    numbers[i] = x;
            //}
            //Array.Sort(numbers);

            //Console.WriteLine("The maximum: " + numbers[9]);

            //Console.WriteLine("The minimum: " + numbers[0]);




            /* -------------------------- 3. Count Even & Odd Numbers   -------------------*/

            //int NumberOfArray;
            //int InputNumber;
            //int countEven = 0;
            //int countOdd = 0;
            //Console.WriteLine("Enter Number of Arrays");
            //NumberOfArray = int.Parse(Console.ReadLine());
            //int[] numbers = new int[NumberOfArray];

            //Console.WriteLine("Enter Numbers");


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    InputNumber = int.Parse(Console.ReadLine());
            //    numbers[i] = InputNumber;

            //    if(InputNumber % 2 == 0)
            //    {

            //        countEven += 1;
            //    }
            //    else
            //    {
            //        countOdd += 1;
            //    }
            //}

            ////for (int i = 0; i < numbers.Length; i++)
            ////{
            ////    Console.WriteLine(numbers[i]);

            ////}



            //Console.WriteLine("Numbers in array: " + numbers.Length);
            //Console.WriteLine("Even Numbers in array: " + countEven);
            //Console.WriteLine("Odd Numbers in array: " + countOdd);

            /* -------------------------- 4. Reverse an Array  -------------------*/


            //int NumberOfArray;
            //int InputNumber;

            //Console.WriteLine("Enter Number of Arrays");
            //NumberOfArray = int.Parse(Console.ReadLine());
            //int[] numbers = new int[NumberOfArray];

            //Console.WriteLine("Enter Numbers");


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    InputNumber = int.Parse(Console.ReadLine());
            //    numbers[i] = InputNumber;


            //}
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);

            //}

            /* -------------------------- 5. Search for a Number in an Array   -------------------*/

            //int NumberOfArray;
            //int InputNumber;
            //int index, search;

            //Console.WriteLine("Enter Number of Arrays");
            //NumberOfArray = int.Parse(Console.ReadLine());
            //int[] numbers = new int[NumberOfArray];

            //Console.WriteLine("Enter Numbers");


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    InputNumber = int.Parse(Console.ReadLine());
            //    numbers[i] = InputNumber;


            //}
            //Console.WriteLine("Enter Number to search");
            //search = int.Parse(Console.ReadLine());

            //index = Array.IndexOf(numbers, search);
            //if (index != -1)
            //{
            //    Console.WriteLine("Number is exists in the array and its position is: " + index);
            //}
            //else
            //{
            //    Console.WriteLine("Number is not exists in the array");
            //}

            /* -------------------------- 6. Sorting an Array (Ascending Order)  -------------------*/

            //int NumberOfArray;
            //int InputNumber;
            //int index, search;

            //Console.WriteLine("Enter Number of Arrays");
            //NumberOfArray = int.Parse(Console.ReadLine());
            //int[] numbers = new int[NumberOfArray];

            //Console.WriteLine("Enter Numbers");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    InputNumber = int.Parse(Console.ReadLine());
            //    numbers[i] = InputNumber;
            //}
            //Array.Sort(numbers);


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(i + " Number after sort is " + numbers[i]);

            //}


            /* -------------------------- 7. Merging Two Arrays -------------------*/

            //int NumberOfArrays;
            //int k;
            //int InputNumber1;
            //int InputNumber2;


            //Console.WriteLine("Enter Size of 1st Array and 2nd Array");
            //NumberOfArrays = int.Parse(Console.ReadLine());
            //int[] numbers1 = new int[NumberOfArrays];

            //Console.WriteLine("Enter Numbers for First Array");

            //for (int i = 0; i < numbers1.Length; i++)
            //{
            //    InputNumber1 = int.Parse(Console.ReadLine());
            //    numbers1[i] = InputNumber1;
            //}


            //int[] numbers2 = new int[NumberOfArrays];

            //Console.WriteLine("Enter Numbers for Secound Array");

            //for (int i = 0; i < numbers2.Length; i++)
            //{
            //    InputNumber2 = int.Parse(Console.ReadLine());
            //    numbers2[i] = InputNumber2;
            //}


            ////int[] mergedArray = numbers1.Concat(numbers2).ToArray();

            //int[] mergedArray = new int[(numbers1.Length * 2)]; 

            //Console.Write("New array: ");


            //for (int i = 0; i < numbers1.Length; i++)
            //{
            //    for ( k = (numbers1.Length+1 ); k < mergedArray.Length; k++)
            //    {
            //        mergedArray[i] = numbers1[i];
            //        mergedArray[k] = numbers2[i];

            //        Console.Write(mergedArray[i]);
            //        Console.Write(mergedArray[k]);
            //    }


            //}



            /* -------------------------- 8. Remove Duplicates from an Array  -------------------*/


            int NumberOfArray;
            int InputNumber;

            Console.WriteLine("Enter Number of Arrays");
            NumberOfArray = int.Parse(Console.ReadLine());
            int[] numbers = new int[NumberOfArray];

            Console.WriteLine("Enter Numbers");


            for (int i = 0; i < numbers.Length; i++)
            {
                InputNumber = int.Parse(Console.ReadLine());
                numbers[i] = InputNumber;


            }
            Array.Sort(numbers);

            int[] mergedArray = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i += 1] != numbers[i -= 1])
                {
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        mergedArray[k] = numbers[i];
                    }
                }
                else
                {

                }


                Console.WriteLine(mergedArray[i]);

            }



            /* -------------------------- 9. Second Largest Number in an Array  -------------------*/


            //int NumberOfArray;
            //int InputNumber;


            //Console.WriteLine("Enter Number of Arrays");
            //NumberOfArray = int.Parse(Console.ReadLine());
            //int[] numbers = new int[NumberOfArray];

            //Console.WriteLine("Enter Numbers");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    InputNumber = int.Parse(Console.ReadLine());
            //    numbers[i] = InputNumber;
            //}
            //Array.Sort(numbers);

            //Console.WriteLine("The second-largest number is " + numbers[1]);





        }

    }
}
