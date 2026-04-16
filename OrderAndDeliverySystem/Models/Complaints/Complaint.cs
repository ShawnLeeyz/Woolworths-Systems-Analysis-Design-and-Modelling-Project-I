using System;
using OrderAndDeliverySystem.Models.People;

namespace OrderAndDeliverySystem.Models.Complaints
{
    public class Complaint
    {
        private int complaintID;
        private string description;
        private string status;
        
        private DateTime dateLogged = DateTime.UtcNow;
        private DateTime dateResolved;
        private Customer customer;

        public Complaint(int complaintID, string description, Customer customer)
        {
            this.complaintID = complaintID;
            this.description = description;
            this.customer = customer;
            this.dateLogged = DateTime.UtcNow;
            this.status = "Open";
        }

        public int getComplaintID()
        {
            return complaintID;
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int ComplaintID
        {
            get { return complaintID; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public DateTime DateLogged
        {
            get { return dateLogged; }
            set { dateLogged = value; }
        }

        public DateTime DateResolved
        {
            get { return dateResolved; }
            set { dateResolved = value; }
        }

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public string getStatus()
        {
            return status;
        }

        public void setStatus(string newStatus)
        {
            status = newStatus;
        }

        public void resolve()
        {
            dateResolved = DateTime.UtcNow;
            setStatus("Resolved");
        }
    }
}
