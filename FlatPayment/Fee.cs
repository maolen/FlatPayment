namespace FlatPayment
{
    public class Fee : Entity
    {
        public string Iin { get; set; }
        public string Phone { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Flat { get; set; }
        public FeeType FeeType { get; set; }
        public int Payment { get; set; }
    }
}
