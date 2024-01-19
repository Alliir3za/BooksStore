namespace BookStore.Domain.Entities;

[Table(nameof(PriceOffer), Schema = nameof(Schema.Base))]
public class PriceOffer
{
    public int NewPrice { get; set; }
    public string PomotionalText { get; set; }
}
