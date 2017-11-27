using ApiCoreEntity.Services.Impl;
using ApiCoreEntity.Services.Inter;
using Microsoft.Extensions.DependencyInjection;

namespace ApiCoreEntity.Infra
{
    public static class Ioc
    {
        public static void AddFactories(this IServiceCollection services)
        {
            services.AddScoped<IBlogService, BlogService>();
        }

    }
}