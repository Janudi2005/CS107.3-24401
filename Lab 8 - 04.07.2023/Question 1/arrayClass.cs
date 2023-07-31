using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    internal class arrayClass
    {
        public int[] arrayMethod(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i += 2)
            {
                Console.Write($"Enter a value{i+1} :");
                int value = Convert.ToInt32(Console.ReadLine());

                array[i] = value;
                array[i + 1] = 0;
            }

            return array;
        }
            
           
          
           
           
    }
}
