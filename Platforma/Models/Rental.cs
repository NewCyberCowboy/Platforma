namespace Platforma.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public decimal Deposit { get; set; }
        public string RentalTerms { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}
