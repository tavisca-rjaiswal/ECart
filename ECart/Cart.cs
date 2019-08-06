using System.Collections.Generic;

namespace ECart
{
    class Cart
    {
        List<CartItem> ItemList;
        double CartTotal = 0, TotalDiscount = 0, DiscountedTotal = 0;
        double DiscountPercentage;
        public Cart()
        {
            ItemList = new List<CartItem>();
        }
        public void DiscountOnTotal(double DiscountPercentage = 25)
        {
            this.DiscountPercentage = DiscountPercentage;
        }
        public double GetTotal()
        {
            ItemList.ForEach(item => CartTotal += item.totalCost);
            return CartTotal;
        }
        public double GetTotalDiscount()
        {
            TotalDiscount = CartTotal * (DiscountPercentage / 100);
            return TotalDiscount;
        }
        public double GetDiscountedTotal()
        {
            DiscountedTotal = CartTotal - TotalDiscount;
            return DiscountedTotal;
        }
        public void AddToCart(CartItem item)
        {
            ItemList.Add(item);
        }
    }
}
