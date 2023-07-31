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
            Console.Write("Enter the radius of the circle:");
            double radius = Convert.ToDouble(Console.ReadLine());

            FindValues findValues = new FindValues();
            Console.WriteLine("Area of the circle is: " + findValues.findArea(radius));
            Console.WriteLine("Circumference of the circle is: " + findValues.findCircumference(radius));

            Console.ReadKey();
        }
    }
}
