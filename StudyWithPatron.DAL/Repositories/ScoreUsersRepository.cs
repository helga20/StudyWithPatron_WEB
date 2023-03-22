using StudyWithPatron.DAL.Models;
using StudyWithPatron.DAL.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyWithPatron.DAL.Repositories
{
    internal sealed class ScoreUsersRepository : GenericRepository<ScoreUsers>, IScoreUsersRepository
    {
        public ScoreUsersRepository(PatronContext context) : base(context) { }
    }
}

