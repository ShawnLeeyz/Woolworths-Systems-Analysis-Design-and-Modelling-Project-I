namespace OrderAndDeliverySystem.Models.People
{
    public class Staff : Person
    {
        private int staffID;
        private string role;
        private bool availability;

        public Staff(int personID, string name, string email, string password, string phoneNumber, int staffID,
                     string role, bool availability)
            : base(personID, name, email, password, phoneNumber)
        {
            this.staffID = staffID;
            this.role = role;
            this.availability = availability;
        }


        public int StaffID
        {
            get { return staffID; }
        }


        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public bool Availability
        {
            get { return availability; }
            set { availability = value; }
        }
    }
}