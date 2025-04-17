namespace ListExercise
{
    internal class Program
    {


        static void Main(string[] args)
        {
            StartSystem();
        }
        public static void DisplayWelcomeMessage()
        {
            Console.WriteLine("\n");
            Console.WriteLine("╔══════════════════════════════════════════════════════╗");
            Console.WriteLine("║            WELCOME TO KHALFANOVISKI SYSTEM           ║");
            Console.WriteLine("╠══════════════════════════════════════════════════════╣");
            Console.WriteLine("║                                                      ║");
            Console.WriteLine("║ Please select an option:                             ║");
            Console.WriteLine("║                                                      ║");
            Console.WriteLine("║ 1. Start Application                                 ║");
            Console.WriteLine("║ 2. Exit Application                                  ║");
            Console.WriteLine("║                                                      ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════╝");
            Console.Write("Enter your choice: ");

            int choice;
            bool on = true;

            do
            {
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        on = false;
                        ShowMainMenu();
                        break;
                    case 2:
                        ExitApplication();
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            } while (on);
        }
        public static void StartSystem()
        {
            DisplayWelcomeMessage();
        }
        public static int ShowMainMenu()
        {
            // Main menu loop
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n");
                Console.WriteLine("╔══════════════════════════════════════════════════════╗");
                Console.WriteLine("║           MAIN MENU - KHALFANOVISKI SYSTEM           ║");
                Console.WriteLine("╠══════════════════════════════════════════════════════╣");
                Console.WriteLine("║                                                      ║");
                Console.WriteLine("║ 1. Top N Frequent Numbers                            ║");
                Console.WriteLine("║ 2. Palindrome Filter                                 ║");
                Console.WriteLine("║ 3. Shift List Elements                               ║");
                Console.WriteLine("║ 4. Unique Words Extractor                            ║");
                Console.WriteLine("║ 0. Exit Application                                  ║");
                Console.WriteLine("║                                                      ║");
                Console.WriteLine("╚══════════════════════════════════════════════════════╝");

                Console.Write("Enter your choice: ");

                try
                {
                    // Get user choice
                    int choice = int.Parse(Console.ReadLine());

                    // Handle user choice
                    switch (choice)
                    {
                        //Top N Frequent Numbers 
                        case 1:
                            try
                            {
                                Console.WriteLine("╔══════════════════════════════════════════════════╗");
                                Console.WriteLine("║            Top N Frequent Numbers                ║");
                                Console.WriteLine("╚══════════════════════════════════════════════════╝");
                                Console.WriteLine("\n");
                                TopFrequentNumbers();

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"\nError: {ex.Message}");
                                Console.WriteLine("Press Enter to continue...");
                                Console.ReadLine();
                            }
                            break;

                        //Palindrome Filter
                        case 2:
                            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                            Console.WriteLine("║                 Palindrome Filter                      ║");
                            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                            Console.WriteLine("\n");
                            FilterPalindromes();
                            Console.ReadLine();

                            break;

                        //Shift List Elements
                        case 3:
                            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                            Console.WriteLine("║                 Shift List Elements                    ║");
                            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                            Console.WriteLine("\n");
                            ShiftListElements();


                            break;

                        //Unique Words Extractor 
                        case 4:
                            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
                            Console.WriteLine("║               Unique Words Extractor                   ║");
                            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
                            Console.WriteLine("\n");
                            ExtractUniqueWords();


                            break;


                        //exit application
                        case 0:
                            ExitApplication();
                            break;

                        //invalid choice
                        default:
                            Console.WriteLine("Invalid choice! Try again.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    // Handle invalid input
                    Console.WriteLine("Invalid input format. Please enter a number.");
                }
                catch (Exception ex)
                {
                    // Handle unexpected errors
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }

                Console.ReadLine();
            }
        }
        public static void ExitApplication()
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                  THANK YOU FOR USING                   ║");
            Console.WriteLine("║                  KHALFANOVISKI SYSTEM                  ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");
            Console.WriteLine("\nExiting the application...");
            Environment.Exit(0);
        }

        public static void TopFrequentNumbers()
        {


            Console.WriteLine("Enter the number of elements in the list:");
            int count = int.Parse(Console.ReadLine());

            // Create a list to store numbers
            List<int> numbersL = new List<int>();

            Console.WriteLine("Enter the numbers in the list:");
            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbersL.Add(number);
            }

            Console.WriteLine("Enter N to get Top N Frequent Numbers:");
            int topN = int.Parse(Console.ReadLine());

            //Create list of unique numbers and their frequencies
            List<int> unique = new List<int>();
            List<int> freq = new List<int>();

            for (int i = 0; i < numbersL.Count; i++)
            {
                int current = numbersL[i];
                bool found = false;

                for (int j = 0; j < unique.Count; j++)
                {
                    if (unique[j] == current)
                    {
                        freq[j]++;
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    unique.Add(current);
                    freq.Add(1);
                }
            }

            //Sort by frequency (and by number if tie)
            for (int i = 0; i < freq.Count - 1; i++)
            {
                for (int j = i + 1; j < freq.Count; j++)
                {
                    if (freq[j] > freq[i] || (freq[j] == freq[i] && unique[j] > unique[i]))
                    {
                        //Swap frequencies
                        int tempFreq = freq[i];
                        freq[i] = freq[j];
                        freq[j] = tempFreq;

                        //Swap corresponding numbers
                        int tempNum = unique[i];
                        unique[i] = unique[j];
                        unique[j] = tempNum;
                    }
                }
            }

            //Show top N
            Console.WriteLine($"\nTop {topN} Frequent Numbers:");
            for (int i = 0; i < topN && i < unique.Count; i++)
            {
                Console.WriteLine(unique[i]);
            }
        }

        public static void FilterPalindromes()
        {
            // Ask the user how many words they want to enter
            Console.WriteLine("Enter the number of words:");
            int count = int.Parse(Console.ReadLine());

            // Create lists to store input words, palindromes, and non-palindromes
            List<string> words = new List<string>();
            List<string> palindromes = new List<string>();
            List<string> nonPalindromes = new List<string>();

            // Input words from the user
            Console.WriteLine("Enter the words:");
            for (int i = 0; i < count; i++)
            {
                string word = Console.ReadLine();
                words.Add(word);
            }

            // Check each word to see if it is a palindrome
            for (int i = 0; i < words.Count; i++)
            {
                string original = words[i].ToLower();
                string reversed = "";

                // Reverse the word using a for loop
                for (int j = original.Length - 1; j >= 0; j--)
                {
                    reversed += original[j];
                }

                // Compare original and reversed
                if (original == reversed)
                {
                    palindromes.Add(original); // It's a palindrome
                }
                else
                {
                    nonPalindromes.Add(original); // It's not a palindrome
                }
            }

            // Show palindromes if any are found
            if (palindromes.Count > 0)
            {
                Console.WriteLine("\nPalindromes found:");
                for (int i = 0; i < palindromes.Count; i++)
                {
                    Console.WriteLine(palindromes[i]);
                }
            }
            else
            {
                Console.WriteLine("\nNo palindromes found.");
            }

            // Show non-palindromes if any exist
            if (nonPalindromes.Count > 0)
            {
                Console.WriteLine("\nNon-palindromes:");
                for (int i = 0; i < nonPalindromes.Count; i++)
                {
                    Console.WriteLine(nonPalindromes[i]);
                }
            }
        }




        public static void ShiftListElements()
        {
            Console.WriteLine("Enter the number of elements in the list:");
            int count = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            Console.WriteLine("Enter the numbers:");
            for (int i = 0; i < count; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }

            Console.WriteLine("Enter K (number of steps to shift right):");
            int k = int.Parse(Console.ReadLine());

            // Handle cases where k > count
            k = k % count;

            // Create a new list to store shifted values
            List<int> shifted = new List<int>();

            // Add the last K elements first
            for (int i = count - k; i < count; i++)
            {
                shifted.Add(numbers[i]);
            }

            // Then add the rest of the elements
            for (int i = 0; i < count - k; i++)
            {
                shifted.Add(numbers[i]);
            }

            Console.WriteLine("\nShifted List:");
            foreach (int num in shifted)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine(); // For clean output
        }




        public static void ExtractUniqueWords()
        {
            Console.WriteLine("Enter a paragraph:");
            string paragraph = Console.ReadLine();

            // Convert to lowercase for case-insensitive comparison
            paragraph = paragraph.ToLower();

            // Replace basic punctuation with spaces
            char[] punctuations = { '.', ',', '!', '?', ';', ':' };
            for (int i = 0; i < punctuations.Length; i++)
            {
                paragraph = paragraph.Replace(punctuations[i], ' ');
            }

            // Split paragraph into words and convert to List<string>
            List<string> words = new List<string>(paragraph.Split(' ', StringSplitOptions.RemoveEmptyEntries));

            List<string> uniqueWords = new List<string>();

            // Add only unique words using for loops
            for (int i = 0; i < words.Count; i++)
            {
                string word = words[i];
                bool exists = false;

                for (int j = 0; j < uniqueWords.Count; j++)
                {
                    if (uniqueWords[j] == word)
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    uniqueWords.Add(word);
                }
            }

            // Sort the list alphabetically using bubble sort
            for (int i = 0; i < uniqueWords.Count - 1; i++)
            {
                for (int j = i + 1; j < uniqueWords.Count; j++)
                {
                    if (string.Compare(uniqueWords[i], uniqueWords[j]) > 0)
                    {
                        string temp = uniqueWords[i];
                        uniqueWords[i] = uniqueWords[j];
                        uniqueWords[j] = temp;
                    }
                }
            }

            // Display sorted unique words
            Console.WriteLine("\nUnique words (sorted):");
            for (int i = 0; i < uniqueWords.Count; i++)
            {
                Console.WriteLine(uniqueWords[i]);
            }
        }
    }
}