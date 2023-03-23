using AutoMapper;
using StudyWithPatron.BLL.Models;
using StudyWithPatron.BLL.Services.Interfaces;
using StudyWithPatron.DAL.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudyWithPatron.BLL.Services
{
    public class ScoreBombsService : BaseService, IScoreBombsService
    {
        public ScoreBombsService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

        public async Task<IEnumerable<ScoreBombsDto>> GetScoreBombs()
        {
            var score_bombs = await _unitOfWork.ScoreBombs.GetAllAsync();

            return _mapper.Map<IEnumerable<ScoreBombsDto>>(score_bombs);
        }
    }
}



