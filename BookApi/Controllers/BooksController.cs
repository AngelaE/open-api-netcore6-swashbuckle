using BookApi.Models;
using BookApiSB.Api.OpenApi;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Consumes(contentType: ContentTypes.APPLICATION_JSON)]
    [Produces(contentType: ContentTypes.APPLICATION_JSON)]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<BooksController> _logger;

        public BooksController(ILogger<BooksController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get the list of all books
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return new Book[] { };
        }
    }
}
