using System;
using OrderAndDeliverySystem.Models.People;
using OrderAndDeliverySystem.Models.Orders;

namespace OrderAndDeliverySystem.Models.Delivery
{
    public class Delivery
    {
        private int deliveryID;
        private string status;
        private DateTime scheduledTime;
        private DateTime deliveredTime;
        private string destination;
        private Order order;
        private DeliveryDriver driver;


        public Delivery(int deliveryID, string status, DateTime scheduledTime, DateTime deliveredTime, string destination, Order order, DeliveryDriver driver)
        {
            this.deliveryID = deliveryID;
            this.status = status;
            this.scheduledTime = scheduledTime;
            this.deliveredTime = deliveredTime;
            this.destination = destination;
            this.order = order;
            this.driver = driver;
        }

        public int DeliveryID
        {
            get { return deliveryID; }
            set { deliveryID = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public DateTime ScheduledTime
        {
            get { return scheduledTime; }
            set { scheduledTime = value; }
        }

        public DateTime DeliveredTime
        {
            get { return deliveredTime; }
            set { deliveredTime = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public Order Order
        {
            get { return order; }
            set { order = value; }
        }

        public DeliveryDriver Driver
        {
            get { return driver; }
            set { driver = value; }
        }
    }
}
