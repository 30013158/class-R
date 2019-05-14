using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_ex
{
    class Program
    {
        static void Main(string[] args)
        {
           /*2 method
            *Animal a1 = new Animal("" , "");
            Console.WriteLine("Enter the name of any animal");
            a1.Name = Console.ReadLine();
            Console.WriteLine("Enter the sound produced by animal");
            a1.Sound = Console.ReadLine();

            Console.WriteLine("\n" + a1.AnimalSays());
            Console.ReadLine();*/

           
            Console.WriteLine("enter the name of animal");
            string name = Console.ReadLine();
            Console.WriteLine("enter the sound made by animal");
            string sound = Console.ReadLine();
            Animal1 a1 = new Animal1(name, sound);
            Console.WriteLine(a1.AnimalSays());
            Console.ReadLine();
        }
    }
    




}
