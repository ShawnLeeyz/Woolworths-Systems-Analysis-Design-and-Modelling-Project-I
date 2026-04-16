using System;
using System.Collections.Generic;
using OrderAndDeliverySystem.Models.People;

namespace OrderAndDeliverySystem.Models.Delivery
{
    public class DeliverySchedule
    {
        private int scheduleID;
        private DateTime assignedDate;
        private List<Delivery> deliveries;
        private DeliveryDriver driver;
        private string status;  

        public DeliverySchedule(int scheduleID, DateTime assignedDate, List<Delivery> deliveries, DeliveryDriver driver, string status)
        {
            this.scheduleID = scheduleID;
            this.assignedDate = assignedDate;
            this.deliveries = deliveries;
            this.driver = driver;
            this.status = status;
        }

        public int ScheduleID
        {
            get { return scheduleID; }
        }

        public List<Delivery> Deliveries
        {
            get { return deliveries; }
        }

        public void addDelivery(Delivery delivery)
        {
            
        }
    }
}
