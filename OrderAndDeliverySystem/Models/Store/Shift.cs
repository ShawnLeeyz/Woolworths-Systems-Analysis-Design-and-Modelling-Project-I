using System;

namespace OrderAndDeliverySystem.Models.Store
{
    public class Shift
    {
        private int shiftID;
        private DateTime shiftDate;
        private DateTime shiftStartTime;
        private DateTime shiftEndTime;

        public Shift() { }

        public int ShiftID
        {
            get { return shiftID; }
        }

        public DateTime ShiftDate
        {
            get { return shiftDate; }
            set { shiftDate = value; }
        }

        public DateTime ShiftStartTime
        {
            get { return shiftStartTime; }
            set { shiftStartTime = value; }
        }

        public DateTime ShiftEndTime
        {
            get { return shiftEndTime; }
            set { shiftEndTime = value; }
        }
    }
}
