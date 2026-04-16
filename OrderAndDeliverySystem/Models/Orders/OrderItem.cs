using OrderAndDeliverySystem.Models.Products;

namespace OrderAndDeliverySystem.Models.Orders
{
    public class OrderItem
    {
        private int quantity;
        private float price;
        private Product product;
        public OrderItem(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
            this.price = product.Price * quantity;
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public float Price
        {
            get { return price; }
        }

        public Product Product
        {
            get { return product; }
        }

    }
}
