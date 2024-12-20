namespace Platforma.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime LastViewedAt { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
