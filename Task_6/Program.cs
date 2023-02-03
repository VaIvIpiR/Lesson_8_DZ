using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        static void Calculate(out int number1, out int number2, out int number3)
        {   Console.WriteLine("Enter 1st number: ");
            number1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number: ");
            number2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3d number: ");
            number3 = Int32.Parse(Console.ReadLine());
            number1 /= 5;
            number2 /= 5;
            number3 /= 5;
            Console.WriteLine($"The result of dividing by 5: 1st number = {number1}, 2nd number = {number2}, 3d number = {number3}");
        }
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int number3;
            Calculate(out number1, out number2, out number3);
            Console.ReadKey();
        }
    }
}
