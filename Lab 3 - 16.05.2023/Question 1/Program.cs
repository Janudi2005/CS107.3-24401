using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //q1
            /*
            int num1;
            int num2;
            int sum;

            Console.Write("Enter num 1:");
            num1 = Convert.ToInt32( Console.ReadLine());

            Console.Write("Enter num 2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 +num2;
            Console.WriteLine("The sum of num1 + num2 = " + sum);
            */

            //Q2
            double num1;
            double num2;
            double sum;
            double sub;
            double multi;
            double div;

            Console.Write("Enter num 1:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter num 2:");
            num2 = Convert.ToDouble(Console.ReadLine());

            sum = num1 + num2;
            sub = num1 - num2;
            multi = num1 * num2;
            div = num1 / num2;

            Console.WriteLine("The sum of num1 & num2 = " + sum);
            Console.WriteLine("The subtraction of num1 & num2 = " + sub);
            Console.WriteLine("The multiplication of num1 & num2 = " + multi);
            Console.WriteLine("The division of num1 & num2 = " + div);
            Console.ReadKey();

        }
    }
}
