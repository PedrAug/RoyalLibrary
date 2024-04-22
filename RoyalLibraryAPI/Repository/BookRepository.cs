using Dapper;
using RoyalLibraryAPI.Models;
using System.Data;

namespace RoyalLibraryAPI.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext _context;

        public BookRepository(DataContext context) 
        {
            _context = context;
        }

        public async Task<IEnumerable<Book>> GetBooks(BookFilter bookFilter) 
        {
            var query = @"SELECT * FROM books";
            var param = new DynamicParameters();
            if (bookFilter.ISBN != null)
            {
                query = query + @" WHERE ISBN ILIKE :ISBN";
                param.Add(name: "ISBN", value: bookFilter.QueryString + "%", direction: ParameterDirection.Input);
            }
            else if (bookFilter.Author != null)
            {
                query = query + @" WHERE CONCAT(First_Name,' ', Last_Name) ILIKE :Author";
                param.Add(name: "Author", value: "%" + bookFilter.QueryString + "%", direction: ParameterDirection.Input);
            }
            else if (bookFilter.Title != null)
            {
                query = query + @" WHERE Title ILIKE :Title";
                param.Add(name: "Title", value: "%" + bookFilter.QueryString + "%", direction: ParameterDirection.Input);
            }else {
                query = query + @" WHERE CONCAT(First_Name,' ', Last_Name) ILIKE :Any OR Title ILIKE :Any OR ISBN ILIKE :Any OR Type ILIKE :Any ";
                param.Add(name: "Any", value: "%" + bookFilter.QueryString + "%", direction: ParameterDirection.Input);
            }
            var bookBase = await _context.Connection.QueryAsync<Book>(query, param);
            return bookBase;

        }

    }
}
