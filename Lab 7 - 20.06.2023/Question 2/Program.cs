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
            int[] array = new int[10];
 
            Console.WriteLine("Enter 10 integer values:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Value {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.ReadKey();
        }
    }
}
