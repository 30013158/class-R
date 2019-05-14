using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your First name");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter your Last name");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter you gross salary");
            double gross = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the tax rate");
            double tax = double.Parse(Console.ReadLine());

            Employee E1 = new Employee(fname, lname, gross,tax);
            
            Console.WriteLine($"Net Salary = ${Math.Round(E1.NetSalary(),2)}");
            Console.ReadLine();
        }
    }
    class Employee
    {

       //when asked for auto properties
        public string Fname { get; set; }
        public string Lname { get; set; }
        public double Gross { get; set; }
        public double Tax { get; set; } = 0.15;

        //method
        public double NetSalary()
        { return Math.Round(Gross*(1-Tax), 1); }

        //constructors
        public Employee(string _fname, string _lname, double _gross, double _tax)
        { Fname = _fname;
            Lname = _lname;
            Gross = _gross;
            Tax = _tax;
        }
        public Employee() { }
    }


}
