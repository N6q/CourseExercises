namespace CourseExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ------------------------------- 1. Even or Odd --------------------------------*/
            //int num;
            //Console.WriteLine("Enter a number");
            //num = int.Parse(Console.ReadLine());



            //if (num / 2 == 0)
            //{
            //    Console.WriteLine("Number " + num + " is Even");
            //}
            //else
            //{
            //    Console.WriteLine("Number " + num + " is Odd");
            //}

            /* ------------------------------- 2. Largest of Three Numbers --------------------------------*/

            //int num1, num2, num3;


            //Console.WriteLine("Enter First Number");
            //num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Secound Number");
            //num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Third Number");
            //num3 = int.Parse(Console.ReadLine());


            //if (num1 >= num2 && num1 >= num3)
            //{
            //    Console.WriteLine("Number " + num1 + " is Largest Number");
            //}
            //else if (num1 <= num2 && num2 >= num3)
            //{
            //    Console.WriteLine("Number " + num2 + " is Largest Number");
            //}
            //else if (num2 <= num3 && num3 >= num1)
            //{
            //    Console.WriteLine("Number " + num3 + " is Largest Number");
            //}
            //else if (num2 == num3 && num3 == num1)
            //{
            //    Console.WriteLine("All numbers are same");
            //}

            /* ------------------------------- 3. Temperature Converter  --------------------------------*/

            //double temp, Result;

            //Console.WriteLine("Enter temperature");
            //temp = double.Parse(Console.ReadLine());


            //Result = (temp * 9 / 5) + 32;

            //Console.WriteLine("Temperature in Fahrenheit " + Result);


            /* ------------------------------- 4. Simple Discount Calculator  --------------------------------*/

            //double itmP, B4Discount, AfterDiscount;

            //Console.WriteLine("Enter item price");
            //itmP = double.Parse(Console.ReadLine());


            //if (itmP > 100)
            //{
            //    B4Discount = (itmP * 10) / 100;

            //    AfterDiscount = itmP - B4Discount;

            //    Console.WriteLine("Item price after Discount: " + AfterDiscount);
            //}
            //else
            //{
            //    Console.WriteLine("Item price should be above $100 to apply a 10% discount");

            //}

            /* ------------------------------- 5. Grading System  --------------------------------*/

            //double score;

            //Console.WriteLine("Enter Student Score");
            //score = double.Parse(Console.ReadLine());

            //if (score > 100 && score < 0)
            //{
            //    Console.WriteLine("Enter Student Score Correctly");
            //}
            //else if (100 >= score && score >= 90)
            //{
            //    Console.WriteLine("Student Grade is 'A' ");
            //}
            //else if (89 <= score && score >= 80)
            //{
            //    Console.WriteLine("Student Grade is 'B' ");
            //}
            //else if (79 <= score && score >= 70)
            //{
            //    Console.WriteLine("Student Grade is 'C' ");
            //}
            //else if (69 <= score && score >= 60)
            //{
            //    Console.WriteLine("Student Grade is 'D' ");
            //}
            //else
            //{
            //    Console.WriteLine("Student Grade is 'F' ");
            //}

            /* ------------------------------- 6. Swap Two Numbers  --------------------------------*/

            //int num1, num2, num3;

            //Console.WriteLine("Enter First Number");
            //num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Secound Number");
            //num2 = int.Parse(Console.ReadLine());


            //num3 = num1;
            //num1 = num2;
            //num2 = num3;

            //Console.WriteLine("New First Number is " + num1);
            //Console.WriteLine("New Secound Number is " + num2);



            /* ------------------------------- 7. Days to Weeks and Days Converter  --------------------------------*/

            //int days;
            //double weeks, RDays;


            //Console.WriteLine("Enter number of days");
            //days = int.Parse(Console.ReadLine());


            //if (days > 0)
            //{
            //    weeks = days / 7;

            //    RDays = days % 7;

            //    Console.WriteLine("Number of weeks: " + weeks + " Remaining days " + RDays);

            //}
            //else
            //{
            //    Console.WriteLine("Enter correct number");
            //}


            /* ------------------------------- 8. Electricity Bill Calculator  --------------------------------*/

            //double NUnit, result;


            //Console.WriteLine("Enter Number of Unit ");
            //NUnit = double.Parse(Console.ReadLine());

            //if (NUnit<0)
            //{
            //    Console.WriteLine("Enter Number of Unit correctly 1 or more");
            //}
            //else if (1 <= NUnit && NUnit <= 100)
            //{
            //    result = NUnit * 0.5;
            //    Console.WriteLine("The price is: $" + result);
            //}

            //else if (101 <= NUnit && NUnit <= 300)
            //{
            //    result = NUnit * 0.75;
            //    Console.WriteLine("The price is: $" + result);
            //}

            //else 
            //{
            //    result = NUnit * 1;
            //    Console.WriteLine("The price is: $" + result);
            //}



            /* ------------------------------- 9. Simple Calculator  --------------------------------*/

            //double num1, num2, result;
            //string operatorr;


            //Console.WriteLine("Enter First Number");
            //num1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter operator (+, -, *, /)");
            //operatorr = Console.ReadLine();

            //Console.WriteLine("Enter Secound Number");
            //num2 = double.Parse(Console.ReadLine());

            //Console.WriteLine(num1 + operatorr + num2);


            //if (operatorr == "+")
            //{
            //    result = num1 + num2;
            //    Console.WriteLine("The Result: " + num1 + operatorr + num2 + " = " + result);

            //}

            //else if (operatorr == "-")
            //{
            //    result = num1 - num2;
            //    Console.WriteLine("The Result: " + num1 + operatorr + num2 + " = " + result);

            //}
            //else if (operatorr == "*")
            //{
            //    result = num1 * num2;
            //    Console.WriteLine("The Result: " + num1 + operatorr + num2 + " = " + result);

            //}
            //else if (operatorr == "/")
            //{if  (num2 != 0) {
            //            result = num1 / num2;
            //            Console.WriteLine("The Result: " + num1 + " / " + num2 + " = " + result);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Cannot divide by 0");
            //        }
            //}
            //else
            //{
            //    Console.WriteLine("Enter Correct Operator!!!!!!!");
            //}
        }
    }
}
