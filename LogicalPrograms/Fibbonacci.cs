using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Fibbonacci
    {
        public void Fibbo()
        {
            int num1 = 0;
            int num2 = 1;
            Console.WriteLine("enter number for fibbonacci series");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nFibbonacci number is:");

            for (int i = 2; i <= count; i++)
            {
                int fab = num1 + num2;
                num1 = num2;
                num2 = fab;
                Console.Write(" " + fab);
            }
        }
    }
}
