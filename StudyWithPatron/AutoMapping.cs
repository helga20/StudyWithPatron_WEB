using AutoMapper;
using StudyWithPatron.Models;
using StudyWithPatron.Dto;
namespace StudyWithPatron
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