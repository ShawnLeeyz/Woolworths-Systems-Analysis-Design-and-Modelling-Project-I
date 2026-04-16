namespace OrderAndDeliverySystem.Models.SupplyChain
{
    public class Supplier
    {
        private int supplierID;
        private string name;
        private string contactInfo;
        private float qualityRating;
        private float reliabilityScore;
        private float priceList;

        public Supplier() { }

        public int SupplierID
        {
            get { return supplierID; }
        }

        public string Name
        {
            get { return name; }
        }

        public string ContactInfo
        {
            get { return contactInfo; }
        }

        public float QualityRating
        {
            get { return qualityRating; }
        }

        public float ReliabilityScore
        {
            get { return reliabilityScore; }
        }

        public float PriceList
        {
            get { return priceList; }
        }
    }
}
