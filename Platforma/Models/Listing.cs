namespace Platforma.Models
{
    public class Listing
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Status { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}
