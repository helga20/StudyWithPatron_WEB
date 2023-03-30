using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudyWithPatron.DAL.Interface;

namespace StudyWithPatron.DAL.Interface
{
    public interface IUnitOfWork
    {
        IScoreBombsRepository ScoreBombs { get; }

        IScoreUsersRepository ScoreUsers { get; }

        IUsersRepository Users { get; }

        Task SaveAsync();
    }
}
