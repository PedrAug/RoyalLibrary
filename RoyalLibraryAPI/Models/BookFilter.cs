namespace RoyalLibraryAPI.Models
{
    public class BookFilter
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Any { get; set; }
        public string QueryString { get; set; }
    }
}
