using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Csh
{
    public delegate void Calculation(int a, int b);

    public class Calculator
    {
        public static void Sum(int a, int b)
        {
            Console.WriteLine($"Sum: {a + b}");
        }

        public static void Sub(int a, int b)
        {
            Console.WriteLine($"Sub: {a - b}");
        }

        public static void Divide(int a, int b)
        {
            if (b != 0)
            {
                Console.WriteLine($"Divide: {a / b}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
        }

        public static void Multi(int a, int b)
        {
            Console.WriteLine($"Multi: {a * b}");
        }
    }

}
