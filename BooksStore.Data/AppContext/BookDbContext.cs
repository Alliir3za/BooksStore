namespace BooksStore.Data.AppContext;

public class BookDbContext : DbContext
{
    public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }

    public BookDbContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=.;database=BookStore;trusted_connection=true;TrustServerCertificate=True;");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<BookAuthor> BookAuthors { get; set; }
    public DbSet<PriceOffer> PriceOffers { get; set; }
}
