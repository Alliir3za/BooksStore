namespace BookStore.Services.Interface;

public interface IBookService
{
    Task<IActionResponse<object>> Update(Book model, CancellationToken ct);
}
