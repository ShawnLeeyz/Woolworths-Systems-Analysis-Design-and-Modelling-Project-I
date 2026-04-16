namespace OrderAndDeliverySystem.Models.Products
{
    public class Product
    {
        private int productID;
        private string name;
        private float price;
        private string category;
        private string nutritionalValue;
        private string description;

        public Product(int productID, string name, float price, string category, string nutritionalValue, string description)
        {
            this.productID = productID;
            this.name = name;
            this.price = price;
            this.category = category;
            this.nutritionalValue = nutritionalValue;
            this.description = description;
        }

        public int ProductID
        {
            get { return productID; }
        }

        public string Name
        {
            get { return name; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Category
        {
            get { return category; }
        }

        public string NutritionalValue
        {
            get { return nutritionalValue; }
        }

        public string Description
        {
            get { return description; }
        }
    }
}
