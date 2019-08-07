namespace ECart
{
    public class CartItem
    {
        Product item;
        int quantity;
        public double TotalMarkedPrice,TotalDiscount,TotalDiscountedPrice;
        public CartItem(Product item, int quantity)
        {
            this.item = item;
            this.quantity = quantity;
            CalculateTotal();
        }
        public void CalculateTotal()
        {
            TotalMarkedPrice = this.item.MarkedPrice * this.quantity;
            TotalDiscount = this.item.Discount * this.quantity;
            TotalDiscountedPrice = this.item.DiscountedPrice * this.quantity;
        }
    }
}
