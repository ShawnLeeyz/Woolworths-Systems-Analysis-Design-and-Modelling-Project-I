using System;

namespace OrderAndDeliverySystem.Models.Complaints
{
    public class Refund
    {
        private int refundID;
        private float amount;
        private string reason;
        private int status;
        private DateTime processedAt;
        private Complaint complaint;

        public Refund(int refundID, float amount, string reason, int status, DateTime processedAt, Complaint complaint)
        {
            this.refundID = refundID;
            this.amount = amount;
            this.reason = reason;
            this.status = status;
            this.processedAt = processedAt;
            this.complaint = complaint;
        }

        public int RefundID
        {
            get { return refundID; }
            set { refundID = value; }
        }

        public float Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public string Reason
        {
            get { return reason; }
            set { reason = value; }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        public DateTime ProcessedAt
        {
            get { return processedAt; }
            set { processedAt = value; }
        }

        public Complaint Complaint
        {
            get { return complaint; }
            set { complaint = value; }
        }

    }
}
