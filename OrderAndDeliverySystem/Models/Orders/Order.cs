using System;
using System.Collections.Generic;

namespace OrderAndDeliverySystem.Models.Orders
{
    public class Order
    {
        private int orderID;
        private DateTime orderDate;
        private string status;
        private int totalPrice;
        private string deliveryAddress;
        private DateTime deliveryTime;
        private List<OrderItem> items;


        public Order() 
        {
            this.items = new List<OrderItem>();
        }

        public Order(int orderID, DateTime orderDate, string status, int totalPrice, string deliveryAddress, DateTime deliveryTime, List<OrderItem> items)
        {
            this.orderID = orderID;
            this.orderDate = orderDate;
            this.status = status;
            this.totalPrice = totalPrice;
            this.deliveryAddress = deliveryAddress;
            this.deliveryTime = deliveryTime;
            this.items = items;
        }
        public int OrderID
        {
            get { return orderID; }
        }

        public DateTime OrderDate
        {
            get { return orderDate; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public int TotalPrice
        {
            get { return totalPrice; }
        }

        public string DeliveryAddress
        {
            get { return deliveryAddress; }
        }

        public DateTime DeliveryTime
        {
            get { return deliveryTime; }
        }

        public List<OrderItem> Items
        {
            get { return items; }
        }

        public void submitOrder()
        {

        }

        public void cancelOrder()
        {

        }

    }
}
