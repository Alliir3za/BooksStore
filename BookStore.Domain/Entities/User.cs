namespace BookStore.Domain.Entities;

[Table(nameof(User), Schema = nameof(Schema.Base))]
public class User
{
    public User() => UserId = Guid.NewGuid();

    public Guid UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public byte Age { get; set; }
    public string Email { get; set; }
    public Gender Gender { get; set; }
    public string PhoneNumber { get; set; }

    public ICollection<Book> Books { get; set; }
}
