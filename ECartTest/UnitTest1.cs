using System;
using Xunit;
using ECart;

namespace ECartTest
{
    public class UnitTest1
    {
        [Fact]
        public void GetTotal_Should_Return_Zero_For_Empty_Cart()
        {
            Cart cart = new Cart();
            double actualOutput = cart.GetTotal();
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
        public void GetDiscountedTotal_Should_Return_Zero_For_Empty_Cart()
        {
            Cart cart = new Cart();
            double actualOutput = cart.GetDiscountedTotal();
            double expectedOutput = 0;
            Assert.Equal(expectedOutput, actualOutput);
        }
        [Fact]
        public void GetTotal_Should_Return_Correct_Value_After_Adding_CartItem()
        {
            Product bottle = new Product("Milton", 500);
            Product bag = new Product("WildCraft", 2500);

            CartItem bottleItem = new CartItem(bottle, 5);
            CartItem bagItem = new CartItem(bag, 3);

            Cart cart = new Cart();
            cart.AddToCart(bottleItem);
            cart.AddToCart(bagItem);

            double actualOutput = cart.GetTotal();
            double expectedOutput = 10000;
            Assert.Equal(expectedOutput, actualOutput);
        }
        [Fact]
        public void GetTotalDiscount_Should_Return_Correct_Value_After_Adding_CartItem()
        {
            Product bottle = new Product("Milton", 500);
            Product bag = new Product("WildCraft", 2500);

            CartItem bottleItem = new CartItem(bottle, 5);
            CartItem bagItem = new CartItem(bag, 3);

            Cart cart = new Cart();
            cart.AddToCart(bottleItem);
            cart.AddToCart(bagItem);
            cart.GetTotal();
            cart.DiscountOnTotal(20);

            double actualOutput = cart.GetTotalDiscount();
            double expectedOutput = 2000;
            Assert.Equal(expectedOutput, actualOutput);
        }
        [Fact]
        public void GetDiscountedTotal_Should_Return_Correct_Value_After_Adding_CartItem()
        {
            Product bottle = new Product("Milton", 500);
            Product bag = new Product("WildCraft", 2500);

            CartItem bottleItem = new CartItem(bottle, 5);
            CartItem bagItem = new CartItem(bag, 3);

            Cart cart = new Cart();
            cart.AddToCart(bottleItem);
            cart.AddToCart(bagItem);
            cart.GetTotal();
            cart.DiscountOnTotal(20);
            cart.GetTotalDiscount();

            double actualOutput = cart.GetDiscountedTotal();
            double expectedOutput = 8000;
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
