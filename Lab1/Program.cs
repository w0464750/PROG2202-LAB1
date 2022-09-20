using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the addition calculator.\nInput your first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input your second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            Console.ReadLine();
        }
    }
}
