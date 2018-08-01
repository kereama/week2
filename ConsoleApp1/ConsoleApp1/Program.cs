using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello, please enter your name: ");
            string input = Console.ReadLine();
            Console.WriteLine("Hello, {0}", input);

            Console.WriteLine("what is your age: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Do you have a Raho or a Teme?: ");
            string input2 = Console.ReadLine();

            Console.WriteLine("kei hea to Kainga?: ");
            string input3 = Console.ReadLine();

            Console.WriteLine("the information gathered: ");
            Console.WriteLine("Name: {0}", input);
            Console.WriteLine("Number: {0}", number);
            Console.WriteLine("Gender: {0}", input2);
            Console.WriteLine("Kainga: {0}", input3);


            Console.ReadLine();

        }
    }
}
