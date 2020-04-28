using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace MvcWebUI.Extensions
{
    public static class DataAccessLayerExtensions
    {
        public static IServiceCollection AddDataAccessLayers(this IServiceCollection services)
        {
            services.AddSingleton<IProductDal, EfProductDal>();
            services.AddSingleton<ICategoryDal, EfCategoryDal>();
            services.AddSingleton<IUserDal, EfUserDal>();

            return services;
        }
    }
}