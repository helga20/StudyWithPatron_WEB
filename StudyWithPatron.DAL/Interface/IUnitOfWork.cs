﻿using StudyWithPatron.DAL.Repositories.Interface;

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
