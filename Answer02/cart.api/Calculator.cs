using System.Linq;
using static cart.api.Controllers.CartController;

namespace cart.api
{
    public class Calculator
    {
        public double CheckDiscount(int amount, double price)
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

        public Cart CalculateMyCart(Cart mycart)
        {
            var MyCart = mycart;
            foreach (var item in MyCart.Products)
            {
                item.Sum = item.Price * item.Amount;
                item.Discount = CheckDiscount(item.Amount, item.Price);
            }
            MyCart.Discount = MyCart.Products.Sum(it => it.Discount);
            MyCart.SumNoDiscount = MyCart.Products.Sum(it => it.Sum);
            MyCart.SumWithDiscount = MyCart.SumNoDiscount - MyCart.Discount;
            return MyCart;
        }
    }
}
