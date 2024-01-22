namespace BooksStore.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class BookController(IBookService bookService) : ControllerBase
{
    private readonly IBookService _bookService = bookService;
}
