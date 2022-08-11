using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class CouponNumber
    {
        public void Coupons()
        {
            int distinct = 0;
            int count = 0;
            int newCoupon=0;
            Console.WriteLine("Enter number for coupon");
            int coupon = Convert.ToInt32(Console.ReadLine());
            bool[] couponCollect = new bool[coupon];

            while (distinct < coupon)
            {
                Random random = new Random();
                newCoupon = (int)(random.NextDouble() * coupon);
                count++;
            
            if (!couponCollect[newCoupon])
            {
                distinct++;
                couponCollect[newCoupon] = true;
            }
            }
            Console.WriteLine("Total number of distinct coupons are: " +count);
        }
    }
}
