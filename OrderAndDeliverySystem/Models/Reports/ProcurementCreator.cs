using System;
using OrderAndDeliverySystem.Models.People;

namespace OrderAndDeliverySystem.Models.Reports
{
    public abstract class ProcurementCreator :ReportCreator
    {
        public abstract override void createReport();
    }
}
