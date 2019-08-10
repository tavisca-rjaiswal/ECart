using System.Collections.Generic;

namespace ECart
{
    public class Cart
    {
        List<CartItem> itemList;
        double totalCartPrice = 0, totalDiscount = 0, totalDiscountedPrice = 0,discountPercentage=0;
        public Cart(string discountType)
        {
            itemList = new List<CartItem>();
            switch(discountType)
            {
                case "FIXED":
                    CalculateCartLevelTotal();
                    break;
                case "CONFIG":
                    discountPercentage = AppConfig.discountPercentage;
                    CalculateCartLevelTotal();
                    break;
                case "CATEGORY":
                    CalculateCategoryLevelTotal();
                    break;
            }
        }
        public void DiscountOnTotal(double discountPercentage = 0)
        {
            this.discountPercentage = discountPercentage;
  //          CalculateCartLevelTotal();
        }
        public void CalculateCartLevelTotal()
        {
            totalCartPrice = 0;
            itemList.ForEach(item =>
            {
                totalCartPrice += item.TotalMarkedPrice;
            });
            totalDiscount = totalCartPrice * (discountPercentage / 100);
            totalDiscountedPrice = totalCartPrice - totalDiscount;
        }
        public void CalculateCategoryLevelTotal()
        {
            totalCartPrice = totalDiscount = 0;
            itemList.ForEach(item =>
            {
                totalCartPrice += item.TotalMarkedPrice;
                totalDiscount += item.TotalDiscount;
            });
            totalDiscountedPrice = totalCartPrice - totalDiscount;
        }
        public double GetTotalCartPrice()
        {
            return totalCartPrice;
        }
        public double GetTotalDiscount()
        {
            return totalDiscount;
        }
        public double GetTotalDiscountedPrice()
        {
            return totalDiscountedPrice;
        }
        public void AddToCart(CartItem item)
        {
            itemList.Add(item);
            CalculateCartLevelTotal();
        }
    }
}
