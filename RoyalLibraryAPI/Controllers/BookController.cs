using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoyalLibraryAPI.Models;
using RoyalLibraryAPI.Service;
using System.Reflection.Metadata;

namespace RoyalLibraryAPI.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("royal-libary/{filter}/{searchString}")]
        public async Task<ICommandResult> GetFilteredBooks(string filter, string searchString)
        {
            var result = await _bookService.GetBooks(filter, searchString);
            return result;
        }
    }
}
