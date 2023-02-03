using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        // для вирішення цієї задачі краще використовувати цикли, наприклад while. як мінімум вони будуть меньшими, елегантнішими
        // і саме головне він не створять переповнення стеку при введені великих значень
        static int QuantityOfRoutes(int N)
        {
            if (N == 0)
                return 1;
            else
                return N * QuantityOfRoutes(N - 1);
        }

        static void Main()
        {
            Console.WriteLine("Enter the number of clients: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int factorial = QuantityOfRoutes(N);

            Console.WriteLine($"Quantity of possible delivery routes: {factorial}");

            Console.ReadKey();
        }
    }
}
