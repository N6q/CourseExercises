namespace WarmUpTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nChoose an Array Exercise:");
                
                Console.WriteLine("1. Find the Most Frequent Number in an Array");
               // Console.WriteLine("2. Check if an Array is Palindrome");
                
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    
                    case 1: MostFrequentNumber(); break;
                   // case 2: CountEvenOdd(); break;
                    
                    case 0: return;
                    default: Console.WriteLine("Invalid choice! Try again."); break;
                }

                Console.ReadLine();
            }
        }

        static void MostFrequentNumber()
        {
            int SizeOfArray;
            int InputNumber;
            int Count=0;       
            int MaxCount = 0;
            int MostFrequentNumber = 0;

            Console.WriteLine("Enter Number of Arrays");
            SizeOfArray = int.Parse(Console.ReadLine());
            int[] numbers = new int[SizeOfArray];

            Console.WriteLine("Enter Numbers");


            for (int i = 0; i < numbers.Length; i++)
            {
                InputNumber = int.Parse(Console.ReadLine());
                numbers[i] = InputNumber;

            }


            Console.WriteLine("Array with duplicates:");
            for (int i = 0; i < SizeOfArray; i++)
            {
                bool isDuplicate = false;
                for (int j = i + 1; j < SizeOfArray; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        Count++;
                    }
                }
                if (Count > MaxCount)
                {
                    MaxCount = Count;
                    MostFrequentNumber = numbers[i];

                }
                Count = 0;
                Console.WriteLine(
                    numbers[i]);




            }
            Console.WriteLine();

        }
    }
}
