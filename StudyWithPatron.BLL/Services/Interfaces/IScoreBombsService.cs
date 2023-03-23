using StudyWithPatron.BLL.Models;

namespace StudyWithPatron.BLL.Services.Interfaces
{
    public interface IScoreBombsService
    {
        Task<IEnumerable<ScoreBombsDto>> GetScoreBombs();
    }
}


