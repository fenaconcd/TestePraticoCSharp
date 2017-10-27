using Microsoft.Extensions.DependencyInjection;

namespace IFEN.CSharp.TestePratico.Data
{
    public static class ServiceCollectionExtensions
    {
        public static void AddTestePraticoData(this IServiceCollection services)
        {
            services.AddScoped<IFENDbContext>(x => new IFENDbContext(x));
            services.AddScoped<IDataContext>(x => new DataContext(x));
        }
    }
}
