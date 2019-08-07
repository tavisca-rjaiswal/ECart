using System;
using Xunit;
using ECart;

namespace ECartTest
{
    public class CartTest
    {
        ConfigureDiscount configureDiscount = new ConfigureDiscount();
        Clothing clothing = new Clothing();
        Dairy dairy = new Dairy();
        Electronics electronics = new Electronics();
        public CartTest()
        {
            configureDiscount.SetDiscount(clothing, 20);
            configureDiscount.SetDiscount(dairy, 10);
            configureDiscount.SetDiscount(electronics, 15);
        }

        [Fact]
        public void GetTotalCartPrice_Should_Return_Zero_For_Empty_Cart()
        {
            Cart cart = new Cart();
            double actualOutput = cart.GetTotalCartPrice();
            double expectedOutput = 0;
            Assert.Equal(expectedOutput, actualOutput);
        }
        [Fact]
        public void GetTotalDiscount_Should_Return_Zero_For_Empty_Cart()
        {
            Cart cart = new Cart();
            double actualOutput = cart.GetTotalDiscount();
            double expectedOutput = 0;
            Assert.Equal(expectedOutput, actualOutput);
        }
        [Fact]
        public void GetTotalDiscountedPrice_Should_Return_Zero_For_Empty_Cart()
        {
            Cart cart = new Cart();
            double actualOutput = cart.GetTotalDiscountedPrice();
            double expectedOutput = 0;
            Assert.Equal(expectedOutput, actualOutput);
        }
        [Fact]
        public void GetTotalCartPrice_Should_Return_Correct_Value_After_Adding_CartItem()
        {
            Product ajio = new Product("Ajio Shirt", 500, clothing);
            Product butter = new Product("Amul", 200, dairy);

            CartItem ajioItem = new CartItem(ajio, 5);
            CartItem butterItem = new CartItem(butter, 3);

            Cart cart = new Cart();
            cart.AddToCart(ajioItem);
            cart.AddToCart(butterItem);
            cart.DiscountOnTotal(10);

            double actualOutput = cart.GetTotalCartPrice();
            double expectedOutput = 2540;
            Assert.Equal(expectedOutput, actualOutput);
        }
        [Fact]
        public void GetTotalDiscount_Should_Return_Correct_Value_After_Adding_CartItem()
        {
            Product ajio = new Product("Ajio Shirt", 500, clothing);
            Product butter = new Product("Amul", 200, dairy);

            CartItem ajioItem = new CartItem(ajio, 5);
            CartItem butterItem = new CartItem(butter, 3);

            Cart cart = new Cart();
            cart.AddToCart(ajioItem);
            cart.AddToCart(butterItem);
            cart.DiscountOnTotal(10);

            cart.GetTotalCartPrice();
            double actualOutput = cart.GetTotalDiscount();
            double expectedOutput = 254;
            Assert.Equal(expectedOutput, actualOutput);
        }
        [Fact]
        public void GetDiscountedTotal_Should_Return_Correct_Value_After_Adding_CartItem()
        {
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
            double actualOutput = cart.GetTotalDiscountedPrice();
            double expectedOutput = 2286;
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
