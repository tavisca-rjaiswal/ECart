using System;
using System.Collections.Generic;
using System.Text;

namespace ECart
{
    public class ConfigureDiscount
    {
        public void SetCategoryDiscount(ICategory category,double discountPercentage)
        {
            category.DiscountPercentage = discountPercentage;
        }
        public void SetConfigDiscount(double discountPercentage=0)
        {
            AppConfig.discountPercentage=discountPercentage;
        }
    }
}
