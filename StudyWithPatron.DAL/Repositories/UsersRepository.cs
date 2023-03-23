using StudyWithPatron.DAL.Models;
using StudyWithPatron.DAL.Repositories.Interface;

namespace StudyWithPatron.DAL.Repositories
{
    internal sealed class UsersRepository : GenericRepository<Users>, IUsersRepository
    {
        public UsersRepository(PatronContext context) : base(context) { }
    }
}