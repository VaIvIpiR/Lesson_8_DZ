using System;

namespace Task_2
{
    internal class Program
    {
        static void Credit(int loan, int payment)
        {
            for (int i = 7; i >= 0; i--)
            {
                loan -= payment;
                Console.WriteLine($"The client has {i - 1} payments left");
                if (loan > 0)
                {
                    Console.WriteLine($"Loan: {loan}");
                    Console.WriteLine("Please, enter the new amount of payment: ");
                    payment = Convert.ToInt32(Console.ReadLine());
                }
                else if (loan == 0)
                {
                    Console.WriteLine("Client`s loan has been repaid");
                    break;
                }
                else
                {
                    Console.WriteLine($"Clint overpaid: {~loan + 1}");
                    break;
                }
                Console.WriteLine("Client expired all of his payments");
            }
        }
        static void Main(string[] args)
        {

            Console.Write("Please, enter the loan: ");
            int loan = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please, enter the amount of payment: ");
            int payment = Convert.ToInt32(Console.ReadLine());

            Credit(loan, payment);
            Console.ReadKey();
        }
    }
}
