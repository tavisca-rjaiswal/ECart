namespace ECart
{
    public class Product
    {
        string name;
        public double MarkedPrice, Discount = 0, DiscountedPrice;
        ICategory category;
        public Product(string name, double markedPrice,ICategory category)
        {
            this.name = name;
            MarkedPrice = markedPrice;
            this.category = category;
            CalculateDiscountedPrice();
        }
        public void CalculateDiscountedPrice()
        {
            Discount = MarkedPrice * (category.DiscountPercentage / 100);
            DiscountedPrice = MarkedPrice - Discount;
        }
    }
}
