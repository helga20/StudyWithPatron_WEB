using Microsoft.EntityFrameworkCore;
using StudyWithPatron.DAL.Models;
//using System.Data.Entity;

namespace StudyWithPatron.DAL
{
    public class PatronContext : DbContext
    {
        public PatronContext(string connectionString) : base(connectionString) { }

        public DbSet<ScoreBombs> ScoreBomb { get; set; }

        public DbSet<ScoreUsers> ScoreUser { get; set; }

        public DbSet<Users> User { get; set; }

    }

}


