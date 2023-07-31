using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number {0}: ", i + 1);
                int input = Convert.ToInt32(Console.ReadLine());
                sum += input;
            }
            double average = (double)sum / n;
            Console.WriteLine("Average of numbers is : {0}.", average);


        }

    }
}



