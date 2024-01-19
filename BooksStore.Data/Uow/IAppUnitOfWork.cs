using BooksStore.Shared.Core.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace BooksStore.Data;

public interface IAppUnitOfWork : IDisposable, IAsyncDisposable
{
    public ChangeTracker ChangeTracker { get; }
    public DatabaseFacade DatabaseFacade { get; }
    public Task<SaveChangeResult> SaveChangesAsync(CancellationToken ct);

    #region repo
    public IGenericRepo<User> UserRepo { get; }
    public IGenericRepo<Book> BookRepo { get; }
    public IGenericRepo<BookAuthor> BookAuthorRepo { get; }
    public IGenericRepo<Review> ReviewRepo { get; }
    public IGenericRepo<Author> AuthorRepo { get; }
    public IGenericRepo<PriceOffer> PriceOfferRepo { get; }
    #endregion
}
