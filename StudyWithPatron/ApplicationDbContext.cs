using Microsoft.EntityFrameworkCore;
using StudyWithPatron.Models;

namespace StudyWithPatron
{
    public class ApplicationDbContext : DbContext
    {
       // string connectionString = "Data Source=Study;Initial Catalog=Study;User ID=postgres;Password=oliak2003;Connect Timeout=150;Encrypt=False;";

        public DbSet<ScoreBombs> ScoreBomb { get; set; }

        public DbSet<ScoreUsers> ScoreUser { get; set; }

        public DbSet<Users> User { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) { }

    }

}


