namespace BookStore.Domain.Dto;
public record UserDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public byte Age { get; set; }
}
