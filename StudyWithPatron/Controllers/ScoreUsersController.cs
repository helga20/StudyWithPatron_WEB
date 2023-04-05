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
    public class ScoreUsersController : ControllerBase
    {
        protected readonly ApplicationDbContext _context;

        public ScoreUsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<ScoreUsers>> Get()
        {
            return _context.ScoreUser.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<ScoreUsers> Get(int id)
        {
            var score_user = _context.ScoreUser.Find(id);
            if (score_user == null)
            {
                return NotFound();
            }
            return score_user;
        }

        [HttpPost]
        public ActionResult<ScoreUsers> Create(ScoreUsers score_user)
        {
            _context.ScoreUser.Add(score_user);
            _context.SaveChanges();

            return CreatedAtAction(nameof(Get), new { id = score_user.id }, score_user);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, ScoreUsers score_user)
        {
            if (id != score_user.id)
            {
                return BadRequest();
            }

            _context.Entry(score_user).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var score_user = _context.ScoreUser.Find(id);
            if (score_user == null)
            {
                return NotFound();
            }

            _context.ScoreUser.Remove(score_user);
            _context.SaveChanges();

            return NoContent();
        }
    }
}


