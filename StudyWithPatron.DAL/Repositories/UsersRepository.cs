using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudyWithPatron.DAL.Models;
using StudyWithPatron.DAL.Repositories.Interface;

namespace StudyWithPatron.DAL.Repositories
{
    internal sealed class UsersRepository : GenericRepository<Users>, IUsersRepository
    {
        public UsersRepository(PatronContext context) : base(context) { }
    }
}