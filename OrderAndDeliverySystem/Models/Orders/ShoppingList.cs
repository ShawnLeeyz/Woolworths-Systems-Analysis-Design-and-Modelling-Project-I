using System.Collections.Generic;
using OrderAndDeliverySystem.Models.Products;

namespace OrderAndDeliverySystem.Models.Orders
{
    public class ShoppingList
    {
        private int listID;
        private string listName;
        private List<Product> items;


        public ShoppingList(int listID, string name, List<Product> items)
        {
            this.listID = listID;
            this.listName = name;
            this.items = items;
        }

        public int ListID
        {
            get { return listID; }
        }

        public string ListName
        {
            get { return listName; }
            set { listName = value; }
        }

        public List<Product> Items
        {
            get { return items; }
        }
        public void addProduct(Product product) 
        {

        }

        public void removeProduct(Product product)
        {

        }
    }
}
