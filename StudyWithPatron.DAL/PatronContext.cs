using Microsoft.EntityFrameworkCore;
using StudyWithPatron.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyWithPatron.DAL
{
    public class PatronContext // : IdentityDbContext
    {
        public PatronContext(DbContextOptions<PatronContext> options) : base(options) { }

        public DbSet<ScoreBombs> ScoreBomb { get; set; }

        public DbSet<ScoreUsers> ScoreUser { get; set; }

        public DbSet<Users> User { get; set; }
    }
}