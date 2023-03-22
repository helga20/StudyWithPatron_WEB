using AutoMapper;
using StudyWithPatron.BLL.Services.Interfaces;
using StudyWithPatron.DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudyWithPatron.BLL.Services
{
    public class UsersService : BaseService, IGoodService
    {
        public UsersService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper) { }

        public async Task<IEnumerable<GoodDto>> GetGoods()
        {
            var goods = await _unitOfWork.Goods.GetAllAsync();

            return _mapper.Map<IEnumerable<GoodDto>>(goods);
        }
    }
}

//C: \Users\Lenovo\source\repos\helga20\StudyWithPatron_WEB\StudyWithPatron.BLL\Services\Interfaces\

//StudyWithPatron