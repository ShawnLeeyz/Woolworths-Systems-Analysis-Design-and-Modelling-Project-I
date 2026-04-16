using System.Collections.Generic;
using OrderAndDeliverySystem.Models.Store;
using StoreTask = OrderAndDeliverySystem.Models.Store.Task;

namespace OrderAndDeliverySystem.Models.People
{
    public class ShiftManager : Staff
    {
        private List<Shift> shifts;

        public ShiftManager() : base(0, string.Empty, string.Empty, string.Empty, string.Empty, 0, string.Empty, true)
        {
            shifts = new List<Shift>();
        }

        public Shift GetShift()
        {
            return null;
        }

        public void AssignTask(StoreOperationStaff staff, StoreTask task)
        {

        }

        public void ReassignTask(StoreTask task, StoreOperationStaff staff)
        {

        }

        public void MonitorProgress()
        {

        }
    }
}
