using Business.Abstract;
using Business.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace MvcWebUI.Extensions
{
    public static class ManagerExtensions
    {
        public static IServiceCollection AddManagers(this IServiceCollection services)
        {
            services.AddScoped<ICartService, CartManager>();   
            services.AddSingleton<IProductService,ProductManager>();
            services.AddSingleton<ICategoryService,CategoryManager>();
            services.AddSingleton<IUserService, UserManager>();
            
            return services;
        }
    }
}