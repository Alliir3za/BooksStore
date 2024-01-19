namespace BookStore.Domain.Entities;

[Table(nameof(BookAuthor), Schema = nameof(Schema.Base))]
public class BookAuthor
{
    public Book Book { get; set; }
    public int BookId { get; set; }


    public Author Author { get; set; }
    public int AuthorId { get; set; }

    public byte Order { get; set; }
}