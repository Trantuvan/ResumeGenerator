using System.Linq.Expressions;

namespace ResumeGenerator.Services;

public static class QueryableExt
{
    public static IQueryable<T> WhereIf<T>(this IQueryable<T> query,
                                           bool condition,
                                           Expression<Func<T, bool>> predicate)
    {
        return condition ? query.Where(predicate) : query;
    }
}