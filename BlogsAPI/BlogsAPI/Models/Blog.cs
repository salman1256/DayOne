namespace BlogsAPI.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string?  Title { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
