using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public void Reverse()
        {
            int rev = 0;
            Console.WriteLine("\nEnter any numbers for Reversing");
            int num = Convert.ToInt32(Console.ReadLine());
            string digits = Convert.ToString(num);
            Console.WriteLine(num + " original number");
            Console.WriteLine("4.Reversed Number");
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                rev += (num % 10) * (int)Math.Pow(10, i);
                num /= 10;
            }
            Console.WriteLine(rev + " Reversed number ");
        }
    }
}
