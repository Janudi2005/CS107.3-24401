using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            /*Console.WriteLine("Hello world!");*/ //printing hello world
            /* int myAge;//declaring a variable called int
             myAge = 18;
             Console.WriteLine("Your age is: " +myAge);*/
            //Q1
            string name = "janudi";
            Console.WriteLine("Your name is: "+name);
            //Q2
            int myAge = 18;
            Console.WriteLine("Your name is:"+name +"\nYour age is:"+myAge);
            //Q3  
            Console.WriteLine("*\n**\n***\n****\n*****");
            
            //Q4
            Console.Write("\n*");
            Console.Write("\n**");
            Console.Write("\n***");
            Console.Write("\n****");
            Console.Write("\n*****");

            //Q5
            Console.WriteLine();
            string myName = "Janudi";
            int age = 18;
            string myCity = "Colombo";
            Console.WriteLine("Your name is:" +myName +"\tYour age is:"+ age +"\tYour city is:"+myCity);
            Console.ReadKey();

        }
    }
}
