namespace Platforma.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string PaymentMethod { get; set; }
        public int SaleId { get; set; }
        public Sale Sale { get; set; }
    }
}
