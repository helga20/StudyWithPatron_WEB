using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using StudyWithPatron.BLL.Profiles;
using StudyWithPatron.BLL.Services;
using StudyWithPatron.BLL.Services.Interfaces;
using StudyWithPatron.DAL;

namespace StudyWithPatron.BLL
{
    public static class DependencyInjection
    {
        public static void AddRatailServices(this IServiceCollection services, IMapperConfigurationExpression mapConfigExpression, string connectionString)
        {
            mapConfigExpression.AddProfile<AutoMapping>();
            services.AddTransient<IUsersService, UsersService>();
            services.AddTransient<IScoreBombsService, ScoreBombsService>();
            services.AddTransient<IScoreUsersService, ScoreUsersService>();
            services.AddDALServices(connectionString);
        }
    }
}