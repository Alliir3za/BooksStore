namespace BookStore.Domain.Entities;

[Table(nameof(Author), Schema = nameof(Schema.Base))]
public class Author
{
    public int AuthorId { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public Gender Gender { get; set; }
    public byte Age { get; set; }
    public Level Level { get; set; }

    public ICollection<BookAuthor> BookAuthors { get; set; }
}