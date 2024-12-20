namespace Platforma.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<Image> Images { get; set; }
        public ICollection<CategoryItem> CategoryItems { get; set; }
    }
}
