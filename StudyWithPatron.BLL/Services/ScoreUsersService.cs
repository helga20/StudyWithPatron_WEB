using AutoMapper;
using StudyWithPatron.BLL.Models;
using StudyWithPatron.BLL.Services.Interfaces;
using StudyWithPatron.DAL.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudyWithPatron.BLL.Services
{
    public class ScoreUsersService : BaseService, IScoreUsersService
    {
        public ScoreUsersService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

        public async Task<IEnumerable<ScoreUsersDto>> GetScoreUsers()
        {
            var score_users = await _unitOfWork.ScoreUsers.GetAllAsync();

            return _mapper.Map<IEnumerable<ScoreUsersDto>>(score_users);
        }
    }
}

