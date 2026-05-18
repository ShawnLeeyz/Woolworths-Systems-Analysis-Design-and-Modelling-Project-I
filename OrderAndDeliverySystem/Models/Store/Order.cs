namespace OrderAndDeliverySystem.Models
{
    public class Order
    {
        private int orderID {get;}
        private List<string> items {get;}
        private string destinationAddress {get;}
        private string status {get; set;}

        public Order(int orderID, List<string> items, string destinationAddress)
        {
            this.orderID = orderID;
            this.items = items;
            this.destinationAddress = destinationAddress;
            this.status = "Pending";
        }

    }
}