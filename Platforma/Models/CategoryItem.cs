namespace Platforma.Models
{
    public class CategoryItem
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}
