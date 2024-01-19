using BooksStore.Data;
using BooksStore.Shared;
using BookStore.Domain.Entities;
using BookStore.Services.Interface;
using BookStore.Services.Resources;
using System.Data.Entity;

namespace BookStore.Services.Implementation;
public class BookService : IBookService
{
    private readonly IAppUnitOfWork _uow;

    public BookService(IAppUnitOfWork uow) => _uow = uow;


    public async Task<IActionResponse<object>> Update(Book model, CancellationToken ct)
    {
        var book = await _uow.BookRepo.FirstOrDefaultAsync(x => x.BookId == model.BookId, ct);


        book.BookName = model.BookName;
        book.Description = model.Description;
        book.Title = model.Title;

        return new ActionResponse<object>(book.Title);

    }
}
