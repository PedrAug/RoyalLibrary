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
            //where username = :username AND password = :password";
            var param = new DynamicParameters();
            if (bookFilter.ISBN != null) 
            {
                query = query + @" WHERE ISBN like %";
                param.Add(name: "ISBN", value: bookFilter.QueryString, direction: ParameterDirection.Input);
            }
            if (bookFilter.Author != null)
            {
                param.Add(name: "Author", value: bookFilter.QueryString, direction: ParameterDirection.Input);
            }
            if (bookFilter.Title != null)
            {
                param.Add(name: "Title", value: bookFilter.QueryString, direction: ParameterDirection.Input);
            }
            //
            //param.Add(name: "password", value: user.Password, direction: ParameterDirection.Input);
            var bookBase = await _context.Connection.QueryAsync<Book>(query, param);
            return bookBase;

        }

    }
}
