namespace BooksStore.Shared.Extensions;
public static class EfExtensions
{
    public static bool SaveChangeResult(this int values) => values >= 1;
}
