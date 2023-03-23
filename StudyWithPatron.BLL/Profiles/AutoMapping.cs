using AutoMapper;
using StudyWithPatron.BLL.Models;
using StudyWithPatron.DAL.Models;

namespace StudyWithPatron.BLL.Profiles
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Users, UsersDto>();
            CreateMap<UsersDto, Users>();

            CreateMap<ScoreBombs, ScoreBombsDto>();
            CreateMap<ScoreBombsDto, ScoreBombs>();

            CreateMap<ScoreUsers, ScoreUsersDto>();
            CreateMap<ScoreUsersDto, ScoreUsers>();
        }
    }
}