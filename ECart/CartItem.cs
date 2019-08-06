namespace ECart
{
    class CartItem
    {
        Product item;
        int quantity;
        public double TotalCost;
        public CartItem(Product item, int quantity)
        {
            this.item = item;
            this.quantity = quantity;
            TotalCost = this.item.Price * this.quantity;
        }
    }
}
