using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using StudyWithPatron.Models;
using StudyWithPatron;

namespace StudyWithPatron.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        protected readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Users>> Get()
        {
            return _context.User.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Users> Get(int id)
        {
            var user = _context.User.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }

        [HttpPost]
        public ActionResult<Users> Create(Users user)
        {
            _context.User.Add(user);
            _context.SaveChanges();

            return CreatedAtAction(nameof(Get), new { id = user.id }, user);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Users user)
        {
            if (id != user.id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = _context.User.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.User.Remove(user);
            _context.SaveChanges();

            return NoContent();
        }
    }


}




