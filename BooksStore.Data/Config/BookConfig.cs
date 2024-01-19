namespace BooksStore.Shared.Config;
public class BookConfig : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(x => x.BookId);

        builder.Property(x => x.BookName).IsUnicode(true)
               .HasColumnType("nvarchar(75)")
               .HasMaxLength(75)
               .IsRequired();

        builder.Property(x => x.Price)
               .IsRequired();

        builder.Property(x => x.PublishOn);

        builder.Property(x => x.Title)
               .HasMaxLength(75)
               .IsRequired();

        builder.Property(x => x.Description).IsUnicode(true)
               .HasColumnType("nvarchar(200)")
               .HasMaxLength(200)
               .IsRequired();

        builder.HasMany(x => x.Reviews)
               .WithOne(x => x.Book)
               .HasForeignKey(x => x.BookId);

        builder.HasOne(x => x.User)
               .WithMany(x => x.Books);

        builder.OwnsOne(x => x.Promotion);

    }
}
