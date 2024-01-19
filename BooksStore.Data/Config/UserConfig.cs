namespace BooksStore.Shared.Config;
public class UserConfig : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.UserId);

        builder.Property(x => x.FirstName)
               .IsUnicode(true)   
               .HasColumnType("nvarchar(100)")
               .HasMaxLength(75)
               .IsRequired();

        builder.Property(x => x.LastName)
               .IsUnicode(true)
               .HasColumnType("nvarchar(100)")
               .HasMaxLength(100)
               .IsRequired();

        builder.Property(x => x.Email)
               .HasMaxLength(80)
               .IsRequired();

        builder.Property(x => x.Age)
               .IsRequired();

        builder.Property(x => x.Gender);

        builder.Property(x => x.PhoneNumber)
               .HasMaxLength(11)
               .IsRequired();

        builder.HasMany(x => x.Books)
               .WithOne(x => x.User)
               .HasForeignKey(x => x.UserId);
    }
}
