namespace OrderAndDeliverySystem.Models.People
{
    // Abstract class representing a person in the system (staff, customers, etc.) It is the base attributes that all staff have.
    public abstract class Person
    {
        private int personID;
        private string name;
        private string email;
        private string password;

        public Person(int personID, string name, string email, string password)
        {
            this.personID = personID;
            this.name     = name;
            this.email    = email;
            this.password = password;
        }

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
    }
}