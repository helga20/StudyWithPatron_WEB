using AutoMapper;
using StudyWithPatron.Models;
using StudyWithPatron.Services.Interfaces;
using StudyWithPatron.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyWithPatron.Services
{
    public class ScoreUsersService : BaseService, IScoreUsersService
    {
        private readonly ApplicationDbContext _context;
        protected readonly IMapper _mapper;

        public ScoreUsersService(IMapper mapper, ApplicationDbContext context) : base(mapper, context) { }

        public IEnumerable<ScoreUsersDto> GetScoreUsers()
        {
            List<ScoreUsersDto> score_users = new List<ScoreUsersDto>();
            score_users = _mapper.Map<List<ScoreUsersDto>>(_context.ScoreUser.ToList());
            return score_users;
        }

        public ScoreUsersDto GetById(int id_user)
        {
            return _mapper.Map<ScoreUsersDto>(_context.ScoreUser.First(c => c.id_user == id_user));
        }

        public ScoreUsersDto Create(ScoreUsersDto score_users)
        {
            if (score_users == null)
            {
                throw new ArgumentNullException(nameof(score_users));
            }

            _context.ScoreUser.Add(_mapper.Map<ScoreUsers>(score_users));
            _context.SaveChanges();
            return score_users;
        }

        public void Update(ScoreUsersDto score_users)
        {
            if (score_users == null)
            {
                throw new ArgumentNullException(nameof(score_users));
            }

            _context.ScoreUser.Update(_mapper.Map<ScoreUsers>(score_users));
            _context.SaveChanges();
        }

        public void DeleteById(int id_user)
        {
            ScoreUsersDto score_users = GetById(id_user);
            _context.User.Remove(_mapper.Map<Users>(score_users));
            _context.SaveChanges();
        }
    }
}
