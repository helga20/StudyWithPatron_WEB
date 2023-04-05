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
    public class ScoreBombsController : ControllerBase
    {
        protected readonly ApplicationDbContext _context;

        public ScoreBombsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<ScoreBombs>> Get()
        {
            return _context.ScoreBomb.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<ScoreBombs> Get(int id)
        {
            var score_bombs = _context.ScoreBomb.Find(id);
            if (score_bombs == null)
            {
                return NotFound();
            }
            return score_bombs;
        }

        [HttpPost]
        public ActionResult<ScoreBombs> Create(ScoreBombs score_bombs)
        {
            _context.ScoreBomb.Add(score_bombs);
            _context.SaveChanges();

            return CreatedAtAction(nameof(Get), new { id = score_bombs.id }, score_bombs);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, ScoreBombs score_bombs)
        {
            if (id != score_bombs.id)
            {
                return BadRequest();
            }

            _context.Entry(score_bombs).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var score_bombs = _context.ScoreBomb.Find(id);
            if (score_bombs == null)
            {
                return NotFound();
            }

            _context.ScoreBomb.Remove(score_bombs);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
