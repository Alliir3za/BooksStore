namespace BookStore.Domain.Entities;

[Table(nameof(Book), Schema = nameof(Schema.Base))]
public class Book
{
    public int BookId { get; set; }

    public User User { get; set; }
    public Guid UserId { get; set; }

    public string BookName { get; set; }

    public string Description { get; set; }

    public string Title { get; set; }

    public int Price { get; set; }

    public Genre Genre { get; set; }

    public DateTime PublishOn { get; set; }

    public PriceOffer Promotion { get; set; }
    public ICollection<Review> Reviews { get; set; }
    public ICollection<BookAuthor> BookAuthors { get; set; }
}