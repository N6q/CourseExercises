using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExerciesePart3
{
    internal class Program
    {

        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nChoose an Array Exercise:");
                Console.WriteLine("1. Array Initialization & Output");
                Console.WriteLine("2. Find Maximum & Minimum in an Array");
                Console.WriteLine("3. Count Even & Odd Numbers");
                Console.WriteLine("4. Reverse an Array");
                Console.WriteLine("5. Search for a Number in an Array");
                Console.WriteLine("6. Sorting an Array (Ascending Order)");
                Console.WriteLine("7. Merging Two Arrays");
                Console.WriteLine("8. Remove Duplicates from an Array");
                Console.WriteLine("9. Find Second Largest Number");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: ArrayInitialization(); break;
                    case 2: FindMaxMin(); break;
                    case 3: CountEvenOdd(); break;
                    case 4: ReverseArray(); break;
                    case 5: SearchNumber(); break;
                    case 6: SortArray(); break;
                    case 7: MergeArrays(); break;
                    case 8: RemoveDuplicates(); break;
                    case 9: FindSecondLargest(); break;                  
                    case 0: return;
                    default: Console.WriteLine("Invalid choice! Try again."); break;
                }

                Console.ReadLine();
            }
        }
        /* -------------------------- 1. Array Initialization & Output -------------------*/

        static void ArrayInitialization()
        {


            int[] numbers = { 5, 6, 7, 4, 1 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }




        /* -------------------------- 2. Find Maximum & Minimum in an Array  -------------------*/

        static void FindMaxMin()
        {

            int x;
            int[] numbers = new int[10];

            Console.WriteLine("Enter 10 Numbers");

            for (int i = 0; i < numbers.Length; i++)
            {
                x = int.Parse(Console.ReadLine());
                numbers[i] = x;
            }
            //Array.Sort(numbers);

            //Console.WriteLine("The maximum: " + numbers[9]);

            //Console.WriteLine("The minimum: " + numbers[0]);



            int max = numbers[0], min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];

                if (numbers[i] < min)
                    min = numbers[i];
            }
            Console.WriteLine($"Max: {max}, Min: {min}");

        }


        /* -------------------------- 3. Count Even & Odd Numbers   -------------------*/

        static void CountEvenOdd()
        {

            int NumberOfArray;
            int InputNumber;
            int countEven = 0;
            int countOdd = 0;
            Console.WriteLine("Enter Number of Arrays");
            NumberOfArray = int.Parse(Console.ReadLine());
            int[] numbers = new int[NumberOfArray];

            Console.WriteLine("Enter Numbers");


            for (int i = 0; i < numbers.Length; i++)
            {
                InputNumber = int.Parse(Console.ReadLine());
                numbers[i] = InputNumber;

                if (InputNumber % 2 == 0)
                {

                    countEven += 1;
                }
                else
                {
                    countOdd += 1;
                }
            }


            Console.WriteLine("Numbers in array: " + numbers.Length);
            Console.WriteLine("Even Numbers in array: " + countEven);
            Console.WriteLine("Odd Numbers in array: " + countOdd);
        }

        /* -------------------------- 4. Reverse an Array  -------------------*/

        static void ReverseArray()
        {


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

            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);

            //}

            Console.WriteLine("Reversed Array:");
            for (int i = NumberOfArray - 1; i >= 0; i--)
                Console.Write(numbers[i] + " ");
            Console.WriteLine();

        }


        /* -------------------------- 5. Search for a Number in an Array   -------------------*/

        static void SearchNumber()
        {

            int NumberOfArray;
            int InputNumber;
            int index, search;

            Console.WriteLine("Enter Number of Arrays");
            NumberOfArray = int.Parse(Console.ReadLine());
            int[] numbers = new int[NumberOfArray];

            Console.WriteLine("Enter Numbers");


            for (int i = 0; i < numbers.Length; i++)
            {
                InputNumber = int.Parse(Console.ReadLine());
                numbers[i] = InputNumber;


            }
            Console.WriteLine("Enter Number to search");
            search = int.Parse(Console.ReadLine());

            index = Array.IndexOf(numbers, search);
            if (index != -1)
            {
                Console.WriteLine("Number is exists in the array and its position is: " + index);
            }
            else
            {
                Console.WriteLine("Number is not exists in the array");
            }
        }


        /* -------------------------- 6. Sorting an Array (Ascending Order)  -------------------*/

        static void SortArray()
        {

            int NumberOfArray;
            int InputNumber;
            int index, search;

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


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(i + " Number after sort is " + numbers[i]);

            }
        }



        /* -------------------------- 7. Merging Two Arrays -------------------*/

        static void MergeArrays()
        {

            int NumberOfArrays;
            int k;
            int InputNumber1;
            int InputNumber2;


            Console.WriteLine("Enter Size of 1st Array and 2nd Array");
            NumberOfArrays = int.Parse(Console.ReadLine());
            int[] numbers1 = new int[NumberOfArrays];

            Console.WriteLine("Enter Numbers for First Array");

            for (int i = 0; i < numbers1.Length; i++)
            {
                InputNumber1 = int.Parse(Console.ReadLine());
                numbers1[i] = InputNumber1;
            }


            int[] numbers2 = new int[NumberOfArrays];

            Console.WriteLine("Enter Numbers for Secound Array");

            for (int i = 0; i < numbers2.Length; i++)
            {
                InputNumber2 = int.Parse(Console.ReadLine());
                numbers2[i] = InputNumber2;
            }


            //int[] mergedArray = numbers1.Concat(numbers2).ToArray();

            int[] mergedArray = new int[(numbers1.Length * 2)];

            //Console.Write("New array: ");


            //for (int i = 0; i < numbers1.Length; i++)
            //{
            //    for (k = (numbers1.Length + 1); k < mergedArray.Length; k++)
            //    {
            //        mergedArray[i] = numbers1[i];
            //        mergedArray[k] = numbers2[i];

            //        Console.Write(mergedArray[i]);
            //        Console.Write(mergedArray[k]);
            //    }


            //}

            for (int i = 0; i < NumberOfArrays; i++)
                mergedArray[i] = numbers1[i];




            for (int i = 0; i < NumberOfArrays; i++)
                mergedArray[NumberOfArrays + i] = numbers2[i];

            Console.WriteLine("Merged Array:");
            for (int i = 0; i < 2 * NumberOfArrays; i++)
                Console.Write(mergedArray[i] + " ");
            Console.WriteLine();


        }



        /* -------------------------- 8. Remove Duplicates from an Array  -------------------*/
        static void RemoveDuplicates()
        {

            int NumberOfArray;
            int InputNumber;

            Console.WriteLine("Enter size of Array");
            NumberOfArray = int.Parse(Console.ReadLine());
            int[] numbers = new int[NumberOfArray];

            Console.WriteLine("Enter Numbers");


            for (int i = 0; i < numbers.Length; i++)
            {
                InputNumber = int.Parse(Console.ReadLine());
                numbers[i] = InputNumber;

            }
            Console.WriteLine("Array without duplicates:");
            for (int i = 0; i < NumberOfArray; i++)
            {
                bool isDuplicate = false;
                for (int j = i + 1; j < NumberOfArray; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate) Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

        }


        /* -------------------------- 9. Second Largest Number in an Array  -------------------*/
        static void FindSecondLargest()
        {

            int NumberOfArray;
            int InputNumber;


            Console.WriteLine("Enter size of Array");
            NumberOfArray = int.Parse(Console.ReadLine());
            int[] numbers = new int[NumberOfArray];

            Console.WriteLine("Enter Numbers");

            for (int i = 0; i < numbers.Length; i++)
            {
                InputNumber = int.Parse(Console.ReadLine());
                numbers[i] = InputNumber;
            }
            int largest = int.MinValue, secondLargest = int.MinValue;

            for (int i = 0; i < NumberOfArray; i++)
            {
                if (numbers[i] > largest)
                {
                    secondLargest = largest;
                    largest = numbers[i];
                }
                else if (numbers[i] > secondLargest && numbers[i] != largest)
                    secondLargest = numbers[i];
            }
            Console.WriteLine($"Second Largest: {secondLargest}");

        }



    }
}
