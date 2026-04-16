namespace OrderAndDeliverySystem.Models.Store
{
    public class Stores
    {
        private int storeID;
        private string location;
        private string openingHours;
        private string promotions;
        private string announcements;
        public Stores() { }

        public int StoreID
        {
            get { return storeID; } 
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public string OpeningHours
        {
            get { return openingHours; }
            set { openingHours = value; }
        }

        public string Promotions
        {
            get { return promotions; }
            set { promotions = value; }
        }

        public string Announcements
        {
            get { return announcements; }
            set { announcements = value; }
        }

    }
}
