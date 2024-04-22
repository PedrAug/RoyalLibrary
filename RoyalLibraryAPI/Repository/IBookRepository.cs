using RoyalLibraryAPI.Models;

namespace RoyalLibraryAPI.Repository
{
    public interface IBookRepository
    {
        Task <IEnumerable<Book>> GetBooks(BookFilter filter);
    }
}
