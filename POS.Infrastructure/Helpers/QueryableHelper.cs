using POS.Infrastructure.Commons.Bases.Request;


//creamos esta clase statica y agregamos el metodo para paginar
namespace POS.Infrastructure.Helpers
{
    public static class QueryableHelper
    {
        public static IQueryable<T> Paginate<T>(this IQueryable<T> queryable, BasePajinationRequest request)
        {
            return queryable.Skip((request.NumPage - 1) * request.Records).Take(request.Records);

        }

    }
}
