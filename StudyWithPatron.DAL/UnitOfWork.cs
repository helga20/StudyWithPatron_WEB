using StudyWithPatron.DAL.Interface;
using StudyWithPatron.DAL.Repositories;
using StudyWithPatron.DAL.Repositories.Interface;

namespace StudyWithPatron.DAL
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly PatronContext _context;
        public IScoreBombsRepository ScoreBombs { get; private set; }

        public IScoreUsersRepository ScoreUsers { get; private set; }

        public IUsersRepository Users { get; private set; }


        private bool _disposed = false;

        public UnitOfWork(PatronContext context)
        {
            _context = context;

            ScoreBombs = new ScoreBombsRepository(context);

            ScoreUsers = new ScoreUsersRepository(context);

            Users = new UsersRepository(context);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}