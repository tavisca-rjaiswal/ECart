using System;

namespace ECart
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigureDiscount configureDiscount = new ConfigureDiscount();
            Clothing clothing = new Clothing();
            Dairy dairy = new Dairy();
            Electronics electronics = new Electronics();

            configureDiscount.SetDiscount(clothing, 20);
            configureDiscount.SetDiscount(dairy,10);
            configureDiscount.SetDiscount(electronics,15);

            Product ajio = new Product("Ajio Shirt", 500, clothing);
            Product butter = new Product("Amul", 200, dairy);

            CartItem ajioItem = new CartItem(ajio, 5);
            CartItem butterItem = new CartItem(butter, 3);

            Cart cart = new Cart();
            cart.AddToCart(ajioItem);
            cart.AddToCart(butterItem);

            cart.DiscountOnTotal(10);

            cart.GetTotalCartPrice();
            cart.GetTotalDiscount();
            cart.GetTotalDiscountedPrice();

            double expectedOutput = 2100;

            Console.ReadLine();
        }
    }
}
