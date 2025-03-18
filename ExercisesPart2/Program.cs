namespace ExercisesPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {





            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nSelect a Program:");
                Console.WriteLine("1. Simple Calculator");
                Console.WriteLine("2. Basic ATM System");
                Console.WriteLine("3. Geometry Calculator");
                Console.WriteLine("4. Factorial of a Number");
                Console.WriteLine("5. Sum of Even and Odd Numbers");
                Console.WriteLine("6. Scientific Calculator");
                Console.WriteLine("7. Print Triangle Pattern");
                Console.WriteLine("8. Print Pyramid Pattern");
                Console.WriteLine("9. Print Diamond Pattern");
                Console.WriteLine("10. Guess the Number Game");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: SimpleCalculator(); break;
                    case 2: BasicATM(); break;
                    case 3: GeometryCalculator(); break;
                    case 4: Factorial(); break;
                    case 5: SumEvenOdd(); break;
                    case 6: ScientificCalculator(); break;
                    case 7: PrintTriangle(); break;
                    case 8: PrintPyramid(); break;
                    case 9: PrintDiamond(); break;
                    case 10: GuessGame(); break;
                    case 0: return;
                    default: Console.WriteLine("Invalid Choice! Try again."); break;
                }
                Console.ReadLine();
            }
        }
        static void SimpleCalculator() {

            /* ------------------------------- 1. Simple Calculator (Switch-Case)  --------------------------------*/

            double num1, num2, result;
            int op;

            do
            {
                

                Console.WriteLine("Enter number of operator \n" +
                    "1: + \n" +
                    "2: - \n" +
                    "3: * \n" +
                    "4: / \n");
                op = int.Parse(Console.ReadLine());


                Console.WriteLine("Enter First Number");
                num1 = double.Parse(Console.ReadLine());


                Console.WriteLine("Enter Secound Number");
                num2 = double.Parse(Console.ReadLine());



                switch (op)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine("The Result: " + num1 + " + " + num2 + " = " + result);
                        break;

                    case 2:
                        result = num1 - num2;
                        Console.WriteLine("The Result: " + num1 + " - " + num2 + " = " + result);
                        break;

                    case 3:
                        result = num1 * num2;
                        Console.WriteLine("The Result: " + num1 + " * " + num2 + " = " + result);

                        break;

                    case 4:
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine("The Result: " + num1 + " / " + num2 + " = " + result);
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by 0");
                        }
                        break;

                    default:
                        Console.WriteLine("Enter Correct Operator!!!!!!!");
                        break;

                }
                Console.WriteLine("Use again");
            }
            while (op != 4);

        }
        /* ------------------------------- 2. Basic ATM System  --------------------------------*/
        static void BasicATM()
        {
            double balance = 1000, newBalance = 0, withdraw = 0, deposit = 0;
            int op;

            do
            {


                Console.WriteLine("Enter number of opreation \n" +
                    "1: Withdraw Money \n" +
                    "2: Deposit Money \n" +
                    "3: Check Balance \n" +
                    "4: Exit \n");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {



                    case 1:
                        Console.WriteLine("Enter amount of money you want to withdraw");
                        withdraw = double.Parse(Console.ReadLine());

                        if (withdraw < balance)
                        {
                            newBalance = balance - withdraw;
                            Console.WriteLine("New balance= " + newBalance);
                        }
                        else
                        {
                            Console.WriteLine("You are brooooock ");

                        }

                        break;

                    case 2:
                        Console.WriteLine("Enter amount of money you want to Deposit");
                        deposit = double.Parse(Console.ReadLine());

                        newBalance = balance + deposit;
                        Console.WriteLine("New balance= " + newBalance);

                        break;

                    case 3:
                        Console.WriteLine("Your balance= " + newBalance);
                        break;

                    case 4:
                        Console.WriteLine("Thank you");

                        break;


                    default:
                        Console.WriteLine("Enter Correct number!!!!!!!");
                        break;

                }
                Console.WriteLine("\nAnother opreation? \n");


            }
            while (op != 4);

        }


        /* ------------------------------- 3. Geometry Calculator  --------------------------------*/


        static void GeometryCalculator()
        {
            //Declartion for Circle 
            double circumference, areaC, radiusC;

            //Declartion for Square
            double sideS, areaS, perimeterS;

            //Declartion for Triangle
            double baseT, heightT, areaT;

            int op;

            do
            {


                Console.WriteLine("Enter number of shape you want \n" +
                    "1: Circle (Calculate Area & Circumference) \n" +
                    "2: Square (Calculate Area & Perimeter) \n" +
                    "3: Triangle (Calculate Area) \n" +
                    "4: Exit \n");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {

                    case 1:
                        Console.WriteLine("Enter Radius");
                        radiusC = double.Parse(Console.ReadLine());

                        areaC = 3.14 * Math.Pow(radiusC, 2);
                        Console.WriteLine("Area of Circle is " + areaC);

                        circumference = 2 * 3.14 * radiusC;
                        Console.WriteLine("Circumference of Circle is " + circumference);

                        break;

                    case 2:
                        Console.WriteLine("Enter Side");
                        sideS = double.Parse(Console.ReadLine());

                        areaS = Math.Pow(sideS, 2);
                        Console.WriteLine("Area of Square is " + areaS);

                        perimeterS = 4 * sideS;
                        Console.WriteLine("Perimeter of Square is " + perimeterS);

                        break;

                    case 3:
                        Console.WriteLine("Enter Base");
                        baseT = double.Parse(Console.ReadLine());


                        Console.WriteLine("Enter Height");
                        heightT = double.Parse(Console.ReadLine());


                        areaT = 0.5 * baseT * heightT;
                        Console.WriteLine("Area of Triangle is " + areaT);


                        break;

                    case 4:
                        Console.WriteLine("Thank you");

                        break;


                    default:
                        Console.WriteLine("Enter Correct number!!!!!!!");
                        break;

                }
                Console.WriteLine("\nAnother opreation? \n");


            }
            while (op != 4);

        }


        /* ------------------------------- 4. Factorial of a Number   --------------------------------*/


        static void Factorial()
        {
            int num, i;
            double f = 1;

            Console.WriteLine("Enter A number");
            num = int.Parse(Console.ReadLine());




            for (i = 1; i <= num; i++)
            {
                f = f * i;
            }



            Console.WriteLine("Factorial of " + num + " is " + f);
        }


        /* ------------------------------- 5. Sum of Even and Odd Numbers   --------------------------------*/

        static void SumEvenOdd()
        {
            double num, evenSum = 0, oddSum = 0;
            int i = 1;

            Console.WriteLine("Enter number");
            num = double.Parse(Console.ReadLine());

            do
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                }
                else
                {
                    oddSum += i;
                }
                i++;
            }
            while (i <= num);

            Console.WriteLine("The sum of Even is " + evenSum);
            Console.WriteLine("\nThe sum of Odd is " + oddSum);

        }

        /* ------------------------------- 6. Scientific Calculator (Switch-Case & Math Functions)  --------------------------------*/

        static void ScientificCalculator()
        {
            double num1, num2, result = 0;
            int op;
            string choicee;

            do
            {


                Console.WriteLine("Enter number of operator \n" +
                    "1: sin \n" +
                    "2: cos \n" +
                    "3: tan \n" +
                    "4: sqrt \n" +
                    "5: log \n" +
                    "6: pow \n");
                op = int.Parse(Console.ReadLine());


                Console.WriteLine("Enter Number");
                num1 = double.Parse(Console.ReadLine());





                switch (op)
                {
                    case 1:
                        result = Math.Sin(num1);
                        Console.WriteLine("The Result: " + result);
                        break;

                    case 2:
                        result = Math.Cos(num1);
                        Console.WriteLine("The Result: " + result);
                        break;

                    case 3:
                        result = Math.Tan(num1);
                        Console.WriteLine("The Result: " + result);
                        break;

                    case 4:
                        result = Math.Sqrt(num1);
                        Console.WriteLine("The Result: " + result);

                        break;

                    case 5:
                        result = Math.Log(num1);
                        Console.WriteLine("The Result: " + result);

                        break;

                    case 6:

                        Console.WriteLine("Enter Power");
                        num2 = double.Parse(Console.ReadLine());

                        result = Math.Pow(num1, num2);
                        Console.WriteLine("The Result: " + result);

                        break;

                    default:
                        Console.WriteLine("Enter Correct Operator!!!!!!!");
                        break;

                }
                Console.WriteLine("Use again? (y/n)");
                choicee = Console.ReadLine();

                if (choicee == "y")
                {
                    Console.Clear();
                }
                else
                {
                    break;
                }



            }
            while (op != 6);

        }




        /* ------------------------------- 7. Print Pattern (For Loop) --------------------------------*/

        static void PrintTriangle()
        {
            int num1;
            Console.WriteLine("Enter Number");
            num1 = int.Parse(Console.ReadLine());

            for (int i = 0; num1 >= i; i++)
            {

                for (int s = 0; s <= i; s++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }

        }


        /* ------------------------------- 8. Print a Pyramid Pattern (For Loop) --------------------------------*/
        static void PrintPyramid()
        {


            int n;
            Console.WriteLine("Enter Number");
            n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }

        }


        /* ------------------------------- 9. Print a Diamond Pattern (For Loop) --------------------------------*/


        static void PrintDiamond()
        {
            int n;
            Console.WriteLine("Enter Number");
            n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }

            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
        /* ------------------------------- 10. Guess Game with helper  --------------------------------*/


        static void GuessGame()
        {
            int RandomNum, InputNum = 0;

            Random rn = new Random();
            RandomNum = rn.Next(1, 100);





            while (RandomNum != InputNum)
            {
                Console.WriteLine("Enter number from 1 to 100");

                InputNum = int.Parse(Console.ReadLine());

                if (InputNum > RandomNum)
                {
                    Console.WriteLine("Try Lower!");
                }
                else if (InputNum < RandomNum)
                {
                    Console.WriteLine("Try Higher!");
                }
                else
                {
                    Console.WriteLine("You win!");
                }
            }

        }
    }
}
