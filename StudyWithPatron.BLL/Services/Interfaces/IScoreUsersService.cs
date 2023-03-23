using StudyWithPatron.BLL.Models;

namespace StudyWithPatron.BLL.Services.Interfaces
{
    public interface IScoreUsersService
    {
        Task<IEnumerable<ScoreUsersDto>> GetScoreUsers();

    }
}
