using Microsoft.Extensions.DependencyInjection;
using StudyWithPatron.DAL.Interface;

namespace StudyWithPatron.DAL
{
    public static class DependencyInjection
    {
        public static void AddDALServices(this IServiceCollection services, string connectionString)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddSingleton(_ => new PatronContext(connectionString));
        }
    }
}