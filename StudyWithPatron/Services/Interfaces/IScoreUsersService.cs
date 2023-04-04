using StudyWithPatron.Dto;


namespace StudyWithPatron.Services.Interfaces
{
    public interface IScoreUsersService
    {
        IEnumerable<ScoreUsersDto> GetScoreUsers();

        ScoreUsersDto GetById(int id_user);

        ScoreUsersDto Create(ScoreUsersDto score_users);

        void Update(ScoreUsersDto score_users);

        void DeleteById(int id_user);

    }
}
