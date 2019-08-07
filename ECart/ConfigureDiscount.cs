using System;
using System.Collections.Generic;
using System.Text;

namespace ECart
{
    public class ConfigureDiscount
    {
        public void SetDiscount(ICategory category,double discountPercentage)
        {
            category.DiscountPercentage = discountPercentage;
        }
    }
}
