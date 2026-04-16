using System.Collections.Generic;
using OrderAndDeliverySystem.Models.Delivery;

namespace OrderAndDeliverySystem.Models.People
{
    using Delivery = OrderAndDeliverySystem.Models.Delivery.Delivery;

    public class DeliveryDriver : Staff
    {
        private string currentLocation;
        private string licenceNumber;

        public DeliveryDriver(int personID, string name, string email, string password, string phoneNumber, int staffID, string role, bool availability) : base(personID, name, email, password, phoneNumber, staffID, role, availability)
        {
        }

        public string LicenceNumber
        {
            get { return licenceNumber; }
            set { licenceNumber = value; }
        }

        // Methods from class diagram
        public string GetCurrentLocation()
        {
            return currentLocation;
        }

        public void SetCurrentLocation(string location)
        {
            currentLocation = location;
        }

        public string GetLicenceNumber()
        {
            return licenceNumber;
        }

        public void UpdateDeliveryStatus(Delivery delivery, string status)
        {

        }

        public void FlagDeliveryIssue(Delivery delivery, string issue)
        {

        }

        public DeliverySchedule ViewDeliverySchedule()
        {

            return null;
        }
    }
}
