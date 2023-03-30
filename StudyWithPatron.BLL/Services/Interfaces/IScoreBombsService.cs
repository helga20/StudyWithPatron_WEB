using StudyWithPatron.BLL.Models;
using StudyWithPatron.DAL.Models;

namespace StudyWithPatron.BLL.Services.Interfaces
{
    public interface IScoreBombsService
    {
        IEnumerable<ScoreBombsDto> GetScoreBombs();

        ScoreBombsDto GetById(int id_user);

        ScoreBombsDto Create(ScoreBombsDto score_bombs);

        void Update(ScoreBombsDto score_bombs);

        void DeleteById(int id_bomb);
    }
}


