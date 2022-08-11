namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n*****************WELCOME TO LOGICAL PROGRAMS*****************");

            Console.WriteLine("1.Fibbonacci Number");
            Console.WriteLine("2.Perfect Number Number");
            Console.WriteLine("3.Prime Number");
            Console.WriteLine("4.Reversed Number");
            Console.WriteLine("5.StopWatch");
            Console.WriteLine("6.Coupon number");

            Console.WriteLine("Enter number for execute a program");
            int check = Convert.ToInt32(Console.ReadLine());

            switch (check)
            {
                case 1:
                    Console.WriteLine("\n********************Fibbonacci Numbers***************************");
                    Fibbonacci fib = new Fibbonacci();
                    fib.Fibbo();
                    break;
                case 2:
                    Console.WriteLine("\n\n*********************Perfect Numbers*******************************");
                    PerfectNumber per = new PerfectNumber();
                    per.Perfect();
                    break;

                case 3:
                    Console.WriteLine("\n\n*********************Prime Numbers*******************************");
                    PrimeNumber prm = new PrimeNumber();
                    
                    break;
                case 4:
                    Console.WriteLine("\n\n**********************Reversed Number****************************");
                    ReverseNumber revrs = new ReverseNumber();
                    revrs.Reverse();
                    break;
                case 5:
                    Console.WriteLine("\n\n**********************StopWatch program****************************");
                    StopWatch stop = new StopWatch();
                    break;
                case 6:
                    Console.WriteLine("\n\n**********************Coupon program****************************");
                    CouponNumber couponNumber=new CouponNumber();
                    couponNumber.Coupons();
                    break;

            }
        }
    }
    
}