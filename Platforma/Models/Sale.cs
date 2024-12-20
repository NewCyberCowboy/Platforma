namespace Platforma.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public int ListingId { get; set; }
        public Listing Listing { get; set; }
        public int BuyerId { get; set; }
        public User Buyer { get; set; }
        public DateTime SaleDate { get; set; }
        public string SaleStatus { get; set; }
    }
}
