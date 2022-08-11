using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public void Perfect()
        {
            int sum = 0;
            Console.WriteLine("Enter Number for perfect number");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine("This is Perfect Number");
            }
            else
            {
                Console.WriteLine("Not a perfect number");
            }
        }
    }
}
