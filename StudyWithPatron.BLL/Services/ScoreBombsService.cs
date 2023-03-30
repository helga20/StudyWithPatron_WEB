using AutoMapper;
using StudyWithPatron.BLL.Models;
using StudyWithPatron.BLL.Services.Interfaces;
using StudyWithPatron.DAL.Models;
using StudyWithPatron.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyWithPatron.BLL.Services
{
    public class ScoreBombsService : BaseService, IScoreBombsService
    {

        private readonly ApplicationDbContext _context;
        protected readonly IMapper _mapper;

        public ScoreBombsService(IMapper mapper, ApplicationDbContext context) : base(mapper, context) { }

        public IEnumerable<ScoreBombsDto> GetScoreBombs()
        {
            List<ScoreBombsDto> score_bombs = new List<ScoreBombsDto>();
            score_bombs = _mapper.Map<List<ScoreBombsDto>>(_context.ScoreBomb.ToList());
            return score_bombs;
        }

        public ScoreBombsDto GetById(int id_user)
        {
            return _mapper.Map<ScoreBombsDto>(_context.ScoreBomb.First(c => c.id_user == id_user));
        }

        public ScoreBombsDto Create(ScoreBombsDto score_bombs)
        {
            if (score_bombs == null)
            {
                throw new ArgumentNullException(nameof(score_bombs));
            }

            _context.ScoreBomb.Add(_mapper.Map<ScoreBombs>(score_bombs));
            _context.SaveChanges();
            return score_bombs;
        }

        public void Update(ScoreBombsDto score_bombs)
        {
            if (score_bombs == null)
            {
                throw new ArgumentNullException(nameof(score_bombs));
            }

            _context.ScoreBomb.Update(_mapper.Map<ScoreBombs>(score_bombs));
            _context.SaveChanges();
        }

        public void DeleteById(int id_bomb)
        {
            ScoreBombsDto score_bombs = GetById(id_bomb);
            _context.ScoreBomb.Remove(_mapper.Map<ScoreBombs>(score_bombs));
            _context.SaveChanges();
        }
    }
}

