using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public PrimeNumber()
        {
            Console.WriteLine("\nenter number for checking Prime or not :");
            int num = Convert.ToInt32(Console.ReadLine());
            Boolean prim = false;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    prim = true;
                    break;
                }

            }
            if (prim)
            {
                Console.WriteLine(num + " is Not Prime");
            }
            else
            {
                Console.WriteLine(num + " is Prime");
            }
        }
    }
}
