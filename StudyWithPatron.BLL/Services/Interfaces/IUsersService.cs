using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudyWithPatron.BLL.Models;

namespace StudyWithPatron.BLL.Services.Interfaces
{
    public interface IUsersService
    {
        Task<IEnumerable<UsersDto>> GetGoods();
    }
}

