namespace Platforma.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }
        public string MessageType { get; set; }
        public int RelatedObject { get; set; }
        public int SenderId { get; set; }
        public User Sender { get; set; }
        public int RecipientId { get; set; }
        public User Recipient { get; set; }
    }
}
