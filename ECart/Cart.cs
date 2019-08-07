using System.Collections.Generic;

namespace ECart
{
    public class Cart
    {
        List<CartItem> itemList;
        double totalCartPrice = 0, totalDiscount = 0, totalDiscountedPrice = 0;
        double discountPercentage;
        public Cart()
        {
            itemList = new List<CartItem>();
        }
        public void DiscountOnTotal(double discountPercentage = 25)
        {
            this.discountPercentage = discountPercentage;
        }
        public double GetTotalCartPrice()
        {
            itemList.ForEach(item => totalCartPrice += item.TotalDiscountedPrice);
            return totalCartPrice;
        }
        public double GetTotalDiscount()
        {
            totalDiscount = totalCartPrice * (discountPercentage / 100);
            return totalDiscount;
        }
        public double GetTotalDiscountedPrice()
        {
            totalDiscountedPrice = totalCartPrice - totalDiscount;
            return totalDiscountedPrice;
        }
        public void AddToCart(CartItem item)
        {
            itemList.Add(item);
        }
    }
}
