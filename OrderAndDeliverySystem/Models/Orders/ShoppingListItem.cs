namespace OrderAndDeliverySystem.Models.Orders
{
    public class ShoppingListItem
        {
            private int quantity;

            public ShoppingListItem() { }

            public int Quantity
            {
                get { return quantity; }
                set { quantity = value; }
            }
    }
}