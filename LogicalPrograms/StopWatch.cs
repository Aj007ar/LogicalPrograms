using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class StopWatch
    {
        public StopWatch()
        {
            Console.WriteLine("Press Enter for Start stopwatch");
            Console.ReadLine();
            DateTime start = DateTime.Now;
            Console.WriteLine("Press Enter to stop the stopwatch");
            Console.ReadLine();
            DateTime stop = DateTime.Now;
            Console.WriteLine("Elapsed time =" + (stop - start));

        }
    }
}
