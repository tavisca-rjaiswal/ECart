namespace ECart
{
    class CartItem
    {
        Product item;
        int Quantity;
        public double totalCost;
        public CartItem(Product item, int Quantity)
        {
            this.item = item;
            this.Quantity = Quantity;
            totalCost = this.item.Price * this.Quantity;
        }
    }
}
