using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[3];
            int[] marks = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter your name:");
                name[i] = Console.ReadLine();
                Console.Write("Enter your marks:");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                if (marks[i] >= 75 && marks[i] <= 100)
                    Console.WriteLine(name[i] +" ="+ " A grade");
                else if (marks[i] >= 60 && marks[i] <= 74)
                    Console.WriteLine(name[i] +" =" + " B grade");
                else if (marks[i] >= 50 && marks[i] <= 59)
                    Console.WriteLine(name[i] + " =" + " C grade");
                else if (marks[i] >= 0 && marks[i] < 40)
                    Console.WriteLine(name[i] + " ="+" fail");
                else
                    Console.WriteLine(name[i] + " =" + " invalid ");


            }
            Console.ReadKey();//avoid closing the window
        }
    }
}
