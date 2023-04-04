using StudyWithPatron.Dto;

namespace StudyWithPatron.Services.Interfaces
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


