using StudyWithPatron.BLL.Models;

namespace StudyWithPatron.BLL.Services.Interfaces
{
    public interface IUsersService
    {
        Task<IEnumerable<UsersDto>> GetUsers();
    }
}

