namespace OrderAndDeliverySystem.Models.People
{
    public abstract class Person
    {
        private int personID;
        private string name;
        private string email;
        private string password;
        private string phoneNumber;
        private int customerID;

        protected Person(int personID, string name, string email, string password, string phoneNumber)
        {
            this.personID = personID;
            this.name = name;
            this.email = email;
            this.password = password;
            this.phoneNumber = phoneNumber;
        }

        // 🔑 Read-only properties (safe access)
        public int PersonID
        {
            get { return personID; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
    }
}