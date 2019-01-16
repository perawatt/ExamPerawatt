using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cart.api
{
    public class Calculator
    {
        public double CheckDiscount(int amount,double price)
        {
            var discountNumber = 4; 
            if (amount < discountNumber)
            {
                return 0;
            }
            else
            {
                int discountAmount = amount / discountNumber;
                return discountAmount * price;
            }
        }
    }
}
