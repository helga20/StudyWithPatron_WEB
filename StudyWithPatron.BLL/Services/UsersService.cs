using AutoMapper;
using StudyWithPatron.BLL.Models;
using StudyWithPatron.BLL.Services.Interfaces;
using StudyWithPatron.DAL.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudyWithPatron.BLL.Services
{
    public class UsersService : BaseService, IUsersService
    {
        public UsersService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

        public async Task<IEnumerable<UsersDto>> GetUsers()
        {
            var users = await _unitOfWork.Users.GetAllAsync();

            return _mapper.Map<IEnumerable<UsersDto>>(users);
        }
    }
}
