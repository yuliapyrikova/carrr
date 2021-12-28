namespace carrr.Domain
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public int OrderPrice { get; set; }
        public int Prepayment { get; set; }
    }
}
