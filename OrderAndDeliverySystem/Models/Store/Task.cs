using OrderAndDeliverySystem.Models.People;

namespace OrderAndDeliverySystem.Models.Store
{
    public class Task
    {
        private int taskID;
        private string description;
        
        private string status;

        private DateTime createdAt;

        private DateTime deadline;

        private StoreOperationStaff assignedStaff;


        public Task() { }
        public int TaskID
        {
            get { return taskID; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
