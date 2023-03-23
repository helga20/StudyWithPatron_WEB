using StudyWithPatron.DAL.Models;
using StudyWithPatron.DAL.Repositories.Interface;

namespace StudyWithPatron.DAL.Repositories
{
    internal sealed class ScoreUsersRepository : GenericRepository<ScoreUsers>, IScoreUsersRepository
    {
        public ScoreUsersRepository(PatronContext context) : base(context) { }
    }
}

