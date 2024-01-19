namespace BooksStore.Shared.Config;
public class AuthorConfig : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.HasKey(x => x.AuthorId);

        builder.Property(x => x.FirstName).IsUnicode(true)
               .HasColumnType("nvarchar(50)")
               .HasMaxLength(50)
               .IsRequired();

        builder.Property(x => x.LastName).IsUnicode(true)
               .HasColumnType("nvarchar(50)")
               .HasMaxLength(50)
               .IsRequired();

        builder.Property(x => x.Age)
               .IsRequired();
    }
}
