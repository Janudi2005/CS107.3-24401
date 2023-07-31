using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array:");
            int size = Convert.ToInt32(Console.ReadLine());

            arrayClass obj1 = new arrayClass();
            int[] array = obj1.arrayMethod(size);

            Console.WriteLine("\nDisplay the array: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + "");
            }
            Console.ReadKey();
        }
    }
}
