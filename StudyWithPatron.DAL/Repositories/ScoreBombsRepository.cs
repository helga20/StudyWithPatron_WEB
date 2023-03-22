using StudyWithPatron.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudyWithPatron.DAL.Models;
using StudyWithPatron.DAL.Repositories.Interface;

namespace StudyWithPatron.DAL.Repositories
{
    internal sealed class ScoreBombsRepository : GenericRepository<ScoreBombs>, IScoreBombsRepository
    {
        public ScoreBombsRepository(PatronContext context) : base(context) { }
    }
}
