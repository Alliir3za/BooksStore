namespace BookStore.Domain.Enum;
public enum Genre
{
    [Description("کودکان")]
    Kids = 1,

    [Description("عاطفی")]
    Emotional = 5,

    [Description("جنایی")]
    Criminal = 10,

    [Description("رمان")]
    Roman = 15,

    [Description("تاریخی")]
    Historical = 20,

    [Description("علمی")]
    Scientific = 25,

    [Description("تاریخی")]
    Political = 30
}
