namespace RoyalLibraryFrontEnd.Models
{
    public class CommandResult
    {
        public bool success { get; set; }
        public string message { get; set; }
        public DataWrapper data { get; set; }
    }

    public class DataWrapper
    {
        public List<Book> bookList { get; set; }
    }
}
