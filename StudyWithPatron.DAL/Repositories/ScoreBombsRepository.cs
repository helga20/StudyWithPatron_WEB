using StudyWithPatron.DAL.Models;
using StudyWithPatron.DAL.Repositories.Interface;

namespace StudyWithPatron.DAL.Repositories
{
    internal sealed class ScoreBombsRepository : GenericRepository<ScoreBombs>, IScoreBombsRepository
    {
        public ScoreBombsRepository(PatronContext context) : base(context) { }
    }
}
