using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateValues calculator = new CalculateValues();
            //Arithmatic operations
            Console.WriteLine("Enter 1 for Addition");
            Console.WriteLine("Enter 2 for Subtraction");
            Console.WriteLine("Enter 3 for Multiplication");
            Console.WriteLine("Enter 4 for Division\n");
            //choice
            Console.Write("Enter Your Choice: ");
            int choice = int.Parse(Console.ReadLine());
            //Getting user inputs
            Console.Write("\nEnter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = 0;
            switch(choice)
            {
                case 1:
                    result = calculator.Addition(num1, num2);
                    break;
                case 2:
                    result = calculator.Subtraction(num1, num2);
                    break;
                case 3:
                    result = calculator.Multiplication(num1, num2);
                    break;
                case 4:
                    result = calculator.Division(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    return;


            }
            Console.WriteLine("\nThe Answer is : "+result);


            Console.ReadKey();
        }
    }
}
