namespace ExercisesPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ------------------------------- 1. Simple Calculator (Switch-Case)  --------------------------------*/

            //double num1, num2, result;
            //int op;

            //do
            //{
            //    Console.Clear();

            //Console.WriteLine("Enter number of operator \n" +
            //    "1: + \n" +
            //    "2: - \n" +
            //    "3: * \n" +
            //    "4: / \n");
            //    op = int.Parse(Console.ReadLine());


            //    Console.WriteLine("Enter First Number");
            //    num1 = double.Parse(Console.ReadLine());


            //    Console.WriteLine("Enter Secound Number");
            //    num2 = double.Parse(Console.ReadLine());



            //    switch (op)
            //    {
            //        case 1:
            //            result = num1 + num2;
            //            Console.WriteLine("The Result: " + num1 + " + " + num2 + " = " + result);
            //            break;

            //        case 2:
            //            result = num1 - num2;
            //            Console.WriteLine("The Result: " + num1 + " - " + num2 + " = " + result);
            //            break;

            //        case 3:
            //            result = num1 * num2;
            //            Console.WriteLine("The Result: " + num1 + " * " + num2 + " = " + result);

            //            break;

            //        case 4:
            //            if (num2 != 0)
            //            {
            //                result = num1 / num2;
            //                Console.WriteLine("The Result: " + num1 + " / " + num2 + " = " + result);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Cannot divide by 0");
            //            }
            //            break;

            //        default:
            //            Console.WriteLine("Enter Correct Operator!!!!!!!");
            //            break;

            //    }
            //    Console.WriteLine("Use again");
            //}
            //while (op != 4);


            /* ------------------------------- 2. Basic ATM System  --------------------------------*/

            double balance =1000, newBalance=0, withdraw=0, deposit=0;
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
                        withdraw= double.Parse(Console.ReadLine());

                        if (withdraw<balance)
                        {
                            newBalance = balance - withdraw;
                            Console.WriteLine("New balance= " + newBalance );
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

                }Console.WriteLine("\nAnother opreation? \n");
            
                
            }
            while (op != 4);
        }
    }
}
