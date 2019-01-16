using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace cart.api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        public Calculator svc = new Calculator();

        public static List<Product> Products = new List<Product>();

        public static Cart MyCart = new Cart { Products = new List<Product>() };
        
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAllProduct()
        {
            return Products.ToList();
        }

        [HttpGet]
        public ActionResult<Cart> GetMyCart()
        {
            if(MyCart.Products == null || MyCart.Products.Count <= 0)
            {
                return new Cart();
            }
            return svc.CalculateMyCart(MyCart);
        }

        // POST api/values
        [HttpPost]
        public void AddProduct([FromBody] Product product)
        {
            product.Id = Guid.NewGuid().ToString();
            Products.Add(product);
        }

        [HttpPost]
        public void AddCart([FromBody] Product product)
        {
            var myProduct = MyCart.Products.FirstOrDefault(it => it.Name == product.Name);
            if (product.Amount <= 0)
            {
                product.Amount = 1;
            }
            if (myProduct == null)
            {
                MyCart.Products.Add(product);
            }
            else
            {
                myProduct.Amount += product.Amount;
            }
        }

        public class Cart
        {
            public string Id { get; set; }
            public List<Product> Products { get; set; }
            public double SumNoDiscount { get; set; }
            public double Discount { get; set; }
            public double SumWithDiscount { get; set; }
        }

        public class Product
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public int Amount { get; set; }
            public double Discount { get; set; }
            public double Sum { get; set; }
        }
    }
}
