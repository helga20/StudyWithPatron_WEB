using StudyWithPatron.BLL.Models;
using StudyWithPatron.DAL.Models;

namespace StudyWithPatron.BLL.Services.Interfaces
{
    public interface IUsersService
    {
        IEnumerable<UsersDto> GetUsers();

        UsersDto GetById(int id);

        UsersDto Create(UsersDto user);

        void Update(UsersDto user);

        void DeleteById(int id_user);

    }
}

