using System;
using System.Collections.Generic;
using OrderAndDeliverySystem.Models.Orders;

namespace OrderAndDeliverySystem.Models.People
{
    public class Customer : Person
    {
        private string deliveryAddress;
        private List<ShoppingList> savedShoppingList;


        public Customer(int customerID, string name, string email, string password, string phoneNumber, string deliveryAddress)
            : base(customerID, name, email, password, phoneNumber)
        {
            this.deliveryAddress = deliveryAddress;
            this.savedShoppingList = new List<ShoppingList>();
        }
        // Property
        public string DeliveryAddress
        {
            get { return deliveryAddress; }
            set { deliveryAddress = value; }
        }

        public List<ShoppingList> SavedShoppingList
        {
            get { return savedShoppingList; }
        }

        // Add item
        public void AddShoppingList(ShoppingList list)
        {
            
        }
    }
}