using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Retail.BLL.Profiles;
using Retail.BLL.Services;
using Retail.BLL.Services.Interfaces;
using Retail.DAL;

namespace Retail.BLL
{
    public static class DependencyInjection
    {
        public static void AddRatailServices(this IServiceCollection services, IMapperConfigurationExpression mapConfigExpression, string connectionString)
        {
            mapConfigExpression.AddProfile<AutoMapping>();
            services.AddTransient<IGoodService, GoodService>();
            services.AddDALServices(connectionString);
        }
    }
}