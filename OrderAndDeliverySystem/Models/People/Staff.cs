namespace OrderAndDeliverySystem.Models.People
{
    // The staff abstract class, which all staff types inherit from. It contains the base attributes and methods that all staff have.
    public abstract class Staff : Person
    {
        private int staffID;
        private string role;
        private bool isAvailable;

        public Staff(int personID, string name, string email, string password,
                    int staffID, string role, bool isAvailable)
            : base(personID, name, email, password)
        {
            this.staffID     = staffID;
            this.role        = role;
            this.isAvailable = isAvailable;
        }

        public Staff(int personID, string name, string email, string password,
                    string phoneNumber, int staffID, string role, bool isAvailable)
            : this(personID, name, email, password, staffID, role, isAvailable)
        {
        }   

        public int StaffID
        {
            get { return staffID; }
        }

        public string Role
        {
            get { return role; }
        }

        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }
    }
}
