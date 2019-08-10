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

            configureDiscount.SetCategoryDiscount(clothing, 20);
            configureDiscount.SetCategoryDiscount(dairy,10);
            configureDiscount.SetCategoryDiscount(electronics,15);

            configureDiscount.SetConfigDiscount(15);

            Product ajio = new Product("Ajio Shirt", 500, clothing);
            Product butter = new Product("Amul", 200, dairy);

            CartItem ajioItem = new CartItem(ajio, 5);
            CartItem butterItem = new CartItem(butter, 3);

            Cart cart = new Cart("CONFIG");
            cart.AddToCart(ajioItem);
            cart.AddToCart(butterItem);
//            cart.DiscountOnTotal(10);

            cart.CalculateCartLevelTotal();
            double actualOutput = cart.GetTotalDiscount();

            Console.WriteLine(actualOutput);
            Console.ReadLine();
        }
    }
}
