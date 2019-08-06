using System.Collections.Generic;

namespace ECart
{
    class Cart
    {
        List<CartItem> ItemList;
        double cartTotal = 0, totalDiscount = 0, discountedTotal = 0;
        double discountPercentage;
        public Cart()
        {
            ItemList = new List<CartItem>();
        }
        public void DiscountOnTotal(double discountPercentage = 25)
        {
            this.discountPercentage = discountPercentage;
        }
        public double GetTotal()
        {
            ItemList.ForEach(item => cartTotal += item.TotalCost);
            return cartTotal;
        }
        public double GetTotalDiscount()
        {
            totalDiscount = cartTotal * (discountPercentage / 100);
            return totalDiscount;
        }
        public double GetDiscountedTotal()
        {
            discountedTotal = cartTotal - totalDiscount;
            return discountedTotal;
        }
        public void AddToCart(CartItem item)
        {
            ItemList.Add(item);
        }
    }
}
