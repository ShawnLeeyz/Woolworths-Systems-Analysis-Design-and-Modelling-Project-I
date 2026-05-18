using System;
using OrderAndDeliverySystem.Models.People;

namespace OrderAndDeliverySystem.Models.Delivery
{
    public class Delivery
    {
        private int deliveryID {get;}
        private string status {get; set;}
        private DateTime scheduledTime {get;}
        private DateTime deliveredTime {get; set;}

        public Delivery() 
        {
            status = "Pending";
        }

        public Delivery(int deliveryID, DateTime scheduledTime)
        {
            this.deliveryID = deliveryID;
            this.scheduledTime = scheduledTime;
            this.status = "Pending";
        }


    }
}
