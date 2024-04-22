using RoyalLibraryAPI.Models;

namespace RoyalLibraryAPI.Service
{
    public interface IBookService
    {
        Task<ICommandResult> GetBooks(string filter, string searchString);
    }
}
