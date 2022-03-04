namespace Gest.UI.Extensions
{
    public static class DbContextExtensions
    {
        public static IQueryable<T> Paginate<T>(this IQueryable<T> items, int? skip = null, int? take = null)
        {
            if (skip is not null && take is not null)
                items = items.Skip(skip ?? 0).Take(take ?? 0);

            if (skip is null && take is not null)
                items = items.Skip(skip ?? 0).Take(take ?? 0);

            return items;
        }
    }
}
