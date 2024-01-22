using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.The_switch_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number (1-3)");
            int number = int.Parse(Console.ReadLine()); // same as Conver.
            switch (number)
            {
                case 1:
                    Console.WriteLine("You entered '1'");
                    break;
                case 2:
                    Console.WriteLine(" you entered '2'");
                    break;
                case 3:
                    Console.WriteLine(" you entered '3'");
                    break;
                default:
                    Console.WriteLine("Invali input. Please enter a number netween 1 and 3.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
