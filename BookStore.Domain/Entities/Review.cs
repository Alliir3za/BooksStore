namespace BookStore.Domain.Entities;

[Table(nameof(Review), Schema = nameof(Schema.Base))]
public class Review
{
    public int ReviewId { get; set; }

    public Book Book { get; set; }
    public int BookId { get; set; }

    public int NumStars { get; set; }

    public string VoterName { get; set; }

    public string Comment { get; set; }
}
