using System.Collections.Generic;
using OrderAndDeliverySystem.Models.Products;

namespace OrderAndDeliverySystem.Models.Orders
{
    public class Cart
    {
        private int cartID;
        private List<OrderItem> items;
        private float totalPrice;

        public Cart(int cartID, List<OrderItem> items, float totalPrice)
        {
            this.cartID = cartID;
            this.items = items;
            this.totalPrice = totalPrice;

        }

        public int CartID
        {
            get { return cartID; }
        }

        public List<OrderItem> Items
        {
            get { return items; }
        }
        public float TotalPrice
        {
            get { return totalPrice; }
        }  

        public void addProduct(Product product, int quantity)
        {
            
        }

        public void removeProduct(Product product)
        {
            
        }

        public Order checkout()
        {
            Order order = new Order();
            return order;
        }

        public void clearCart()
        {
            
        }
    }
}
