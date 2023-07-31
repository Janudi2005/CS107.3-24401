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

            Employee employee = new Employee();
 
            Console.Write("Enter Employee ID: ");
            int empID = Convert.ToInt32(Console.ReadLine());
            employee.SetEmpID(empID);

            Console.Write("Enter Employee Name: ");
            string empName = Console.ReadLine();
            employee.SetEmpName(empName);

            Console.Write("Enter Employee Designation: ");
            string empDesignation = Console.ReadLine();
            employee.SetEmpDesignation(empDesignation);

            
            Console.WriteLine("Hello " + employee.GetEmpName() + "! Your Employee ID is " + employee.GetEmpID() + " and you are a " + employee.GetEmpDesignation() + ".");
 
            Console.ReadLine();
        }
    }

    public class Employee
    {
        private int empID;
        private string empName;
        private string empDesignation;

        public int GetEmpID()
        {
            return empID;
        }

        public void SetEmpID(int empID)
        {
            this.empID = empID;
        }

        public string GetEmpName()
        {
            return empName;
        }

        public void SetEmpName(string empName)
        {
            this.empName = empName;
        }

        public string GetEmpDesignation()
        {
            return empDesignation;
        }

        public void SetEmpDesignation(string empDesignation)
        {
            this.empDesignation = empDesignation;
        }
    }       
  }
 
    

 
