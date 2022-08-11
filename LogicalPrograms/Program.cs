namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*****************WELCOME TO LOGICAL PROGRAMS*****************");

            Console.WriteLine("1.Fibbonacci Number");
          

            Console.WriteLine("Enter number for execute a program");
            int check = Convert.ToInt32(Console.ReadLine());

            switch (check)
            {
                case 1:
                    Console.WriteLine("\n********************Fibbonacci Numbers***************************");
                    Fibbonacci fib = new Fibbonacci();
                    fib.Fibbo();
                    break;
                
            }
        }
    }
    
}