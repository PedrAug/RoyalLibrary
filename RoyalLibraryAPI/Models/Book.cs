namespace RoyalLibraryAPI.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public int TotalCopies { get; set; }

        public int CopiesInUse { get; set; }

        public string Type { get; set; }

        public string ISBN { get; set; }

        public string Category { get; set; }
    }
}
