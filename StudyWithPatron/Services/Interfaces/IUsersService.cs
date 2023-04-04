using StudyWithPatron.Dto;

namespace StudyWithPatron.Services.Interfaces
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

