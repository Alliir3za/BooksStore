using BooksStore.Data.AppContext;
using BooksStore.Shared.Core.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace BooksStore.Data;

public class AppUnitOfWork : IAppUnitOfWork
{
    private readonly BookDbContext _dbContext;

    public ChangeTracker ChangeTracker => _dbContext.ChangeTracker;
    public DatabaseFacade DatabaseFacade => _dbContext.Database;

    public async Task<SaveChangeResult> SaveChangesAsync(CancellationToken ct)
    {
        try
        {
            await _dbContext.SaveChangesAsync(ct);
            return new();
        }
        catch (DbUpdateConcurrencyException e)
        {
            return new(SaveChangesResultType.UpdateConcurrencyException, e.Message);
        }
        catch (DbUpdateException e)
        {
            return new(SaveChangesResultType.UpdateException, e.Message);
        }
    }

    public IGenericRepo<User> UserRepo => _dbContext.GetService<IGenericRepo<User>>();
    public IGenericRepo<Book> BookRepo => _dbContext.GetService<IGenericRepo<Book>>();
    public IGenericRepo<BookAuthor> BookAuthorRepo => _dbContext.GetService<IGenericRepo<BookAuthor>>();
    public IGenericRepo<Review> ReviewRepo => _dbContext.GetService<IGenericRepo<Review>>();
    public IGenericRepo<Author> AuthorRepo => _dbContext.GetService<IGenericRepo<Author>>();
    public IGenericRepo<PriceOffer> PriceOfferRepo => _dbContext.GetService<IGenericRepo<PriceOffer>>();

    public void Dispose()
    {
        _dbContext.Dispose();
        GC.SuppressFinalize(this);
    }

    public async ValueTask DisposeAsync()
    {
        await _dbContext.DisposeAsync();
        GC.SuppressFinalize(this);
    }
}
