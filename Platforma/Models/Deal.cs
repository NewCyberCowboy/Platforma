namespace Platforma.Models
{
    public class Deal
    {
        public int Id { get; set; }
        public string DealType { get; set; }
        public DateTime CompletedAt { get; set; }
        public string Status { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}
