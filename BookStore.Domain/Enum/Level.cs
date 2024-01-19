namespace BookStore.Domain.Enum;
public enum Level
{
    [Description("مبتدی")]
    Beginner = 1,

    [Description("متوسط")]
    Amatur = 5,

    [Description("ماهر")]
    Professional = 10,

    [Description("استاد")]
    Expert = 15
}
