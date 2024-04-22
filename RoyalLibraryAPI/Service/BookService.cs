using RoyalLibraryAPI.Models;
using RoyalLibraryAPI.Repository;

namespace RoyalLibraryAPI.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<ICommandResult> GetBooks(string filter, string searchString)
        {
            BookFilter searchModel = new BookFilter();
            bool Success = false;
            List<Book> books = new List<Book>();


            switch (filter)
            {
                case "Title":
                    searchModel.Title = searchString;
                    searchModel.QueryString = searchString;
                    break;
                case "Author":
                    searchModel.Author = searchString;
                    searchModel.QueryString = searchString;
                    break;
                case "ISBN":
                    searchModel.ISBN = searchString;
                    searchModel.QueryString = searchString;
                    break;
                default:
                    searchModel.QueryString = searchString;
                    break;
            }


            var bookList = await _bookRepository.GetBooks(searchModel);

            Success = (bookList.Any()) ? true : false;

            return new CommandResult(Success, "", new { bookList });
        }

    }
}
