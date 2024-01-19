namespace BooksStore.Shared.Config;
public class BookAuthorConfig : IEntityTypeConfiguration<BookAuthor>
{
    public void Configure(EntityTypeBuilder<BookAuthor> builder)
    {
        builder.HasKey(x => new { x.BookId, x.AuthorId });

        builder.HasOne(x => x.Book)
               .WithMany(x => x.BookAuthors)
               .HasForeignKey(x => x.BookId);

        builder.HasOne(x => x.Author)
               .WithMany(x => x.BookAuthors)
               .HasForeignKey(x => x.AuthorId);
    }
}
