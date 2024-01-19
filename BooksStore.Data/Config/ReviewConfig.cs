namespace BooksStore.Data.Config;
public class ReviewConfig : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder.HasKey(x => x.ReviewId);

        builder.Property(x => x.Comment).IsUnicode(true)
               .HasColumnType("nvarchar(50)")
               .HasMaxLength(50);

        builder.Property(x => x.NumStars);

        builder.Property(x => x.VoterName).IsUnicode(true)
               .HasColumnType("nvarchar(45)")
               .HasMaxLength(45)
               .IsRequired();

        builder.HasOne(x => x.Book)
               .WithMany(x => x.Reviews)
               .HasForeignKey(x => x.BookId);
    }
}
