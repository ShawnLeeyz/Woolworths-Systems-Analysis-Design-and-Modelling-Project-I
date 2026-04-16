using OrderAndDeliverySystem.Models.Complaints;

namespace OrderAndDeliverySystem.Models.People
{
    public class CustomerServiceRepresentative : Staff
    {

        private List<Complaint> assignedComplaints;
        public CustomerServiceRepresentative(int personID, string name, string email, string password, string phoneNumber,
                                             int staffID, string role, bool availability)
            : base(personID, name, email, password, phoneNumber, staffID, role, availability)
        {
            this.assignedComplaints = new List<Complaint>();
        }

        public List<Complaint> AssignedComplaints
        {
            get { return assignedComplaints; }
        }

        public void updateComplaint(Complaint complaint, string status)
        {
            
        }

        public void resolveComplaint(Complaint complaint)
        {
            
        }

        public Refund processRefund(Complaint complaint)
        {
            return null;
        }

        public void sendNotificationToCustomer(Complaint complaint, string message)
        {
            
        }
    }
}
