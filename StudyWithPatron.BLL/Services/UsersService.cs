global using StudyWithPatron.DAL.Contex;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using StudyWithPatron.BLL.Models;
using StudyWithPatron.BLL.Services.Interfaces;
using StudyWithPatron.DAL;
using StudyWithPatron.DAL.Models;
using System.Data;
using AutoMapper;
using System;

namespace StudyWithPatron.BLL.Services
{
    public class UsersService : BaseService, IUsersService
    {
        private readonly ApplicationDbContext _context;
        protected readonly IMapper _mapper;

        public UsersService(IMapper mapper, ApplicationDbContext context) :base(mapper, context) {}

        public IEnumerable<UsersDto> GetUsers()
        {
            List<UsersDto>users = new List<UsersDto>();
            users = _mapper.Map<List<UsersDto>>(_context.User.ToList());
            return users;
        }

        public UsersDto GetById(int id)
        {
            return _mapper.Map<UsersDto>(_context.User.First(c => c.id == id));   
        }

        public UsersDto Create(UsersDto user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            if (_context.User.Find() ==_mapper.Map<Users>(user))
            {
                throw new ArgumentException("Such user already exists:", nameof(user));
            }

            _context.User.Add(_mapper.Map<Users>(user));
            _context.SaveChanges();
            return user;
        }

        public void Update(UsersDto user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            _context.User.Update(_mapper.Map<Users>(user));
            _context.SaveChanges();
        }

        public void DeleteById(int id_user)
        {
            UsersDto user = GetById(id_user);
            _context.User.Remove(_mapper.Map<Users>(user));
            _context.SaveChanges();
        }
    }
}