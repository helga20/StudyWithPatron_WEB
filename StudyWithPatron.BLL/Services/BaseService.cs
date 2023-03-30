using AutoMapper;
using StudyWithPatron.DAL;

namespace StudyWithPatron.BLL.Services
{
    public abstract class BaseService
    { 
        protected IMapper _mapper;
        protected ApplicationDbContext _context;
        public BaseService(IMapper mapper, ApplicationDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
    }
}
