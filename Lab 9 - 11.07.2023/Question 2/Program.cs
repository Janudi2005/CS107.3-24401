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

        }
        public class Calculator
        {
            private int num1;
            private int num2;

            public int   Operand1
            {
                get { return num1; }
                set { num1 = value; }
            }

            public int Operand2
            {
                get { return  num2; }
                set { num2 = value; }
            }

            public int Addition()
            {
                return num1 + num2;
            }

            public int Subtraction()
            {
                return num1 - num2;
            }

            public int Multiplication()
            {
                return  num1 * num2;
            }

            public int Division()
            {
                if (num2 == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }

                return  num1 /  num2;
            }
        }
    }
}
