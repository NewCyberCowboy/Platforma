namespace Platforma.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string File { get; set; }
        public string Link { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}
