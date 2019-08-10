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
            configureDiscount.SetCategoryDiscount(clothing, 20);
            configureDiscount.SetCategoryDiscount(dairy, 10);
            configureDiscount.SetCategoryDiscount(electronics, 15);
            configureDiscount.SetConfigDiscount(15);
        }

        [Fact]
        public void GetTotalCartPrice_Should_Return_Zero_For_Empty_Cart()
        {
            Cart cart = new Cart("CONFIG");
            double actualOutput = cart.GetTotalCartPrice();
            double expectedOutput = 0;
            Assert.Equal(expectedOutput, actualOutput);
        }
        [Fact]
        public void GetTotalDiscount_Should_Return_Zero_For_Empty_Cart()
        {
            Cart cart = new Cart("CONFIG");
            double actualOutput = cart.GetTotalDiscount();
            double expectedOutput = 0;
            Assert.Equal(expectedOutput, actualOutput);
        }
        [Fact]
        public void GetTotalDiscountedPrice_Should_Return_Zero_For_Empty_Cart()
        {
            Cart cart = new Cart("CONFIG");
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

            Cart cart = new Cart("FIXED");
            cart.AddToCart(ajioItem);
            cart.AddToCart(butterItem);
            cart.DiscountOnTotal(10);

            cart.CalculateCartLevelTotal();
            double actualOutput = cart.GetTotalCartPrice();
            double expectedOutput = 3100;
            Assert.Equal(expectedOutput, actualOutput);
        }
        [Fact]
        public void GetTotalDiscount_Should_Return_Correct_Value_After_Adding_CartItem()
        {
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
            double expectedOutput = 465;
            Assert.Equal(expectedOutput, actualOutput);
        }
        [Fact]
        public void GetDiscountedTotal_Should_Return_Correct_Value_After_Adding_CartItem()
        {
            Product ajio = new Product("Ajio Shirt", 500, clothing);
            Product butter = new Product("Amul", 200, dairy);

            CartItem ajioItem = new CartItem(ajio, 5);
            CartItem butterItem = new CartItem(butter, 3);

            Cart cart = new Cart("CATEGORY");
            cart.AddToCart(ajioItem);
            cart.AddToCart(butterItem);
            //            cart.DiscountOnTotal(10);

            cart.CalculateCategoryLevelTotal();
            double actualOutput = cart.GetTotalDiscountedPrice();
            double expectedOutput = 2540;
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
