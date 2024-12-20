namespace Platforma.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public int PublicationYear { get; set; }
        public string Author { get; set; }
        public string ReleaseYear { get; set; }
        public string Manufacturer { get; set; }
        public ICollection<CategoryItem> CategoryItems { get; set; }
    }
}
