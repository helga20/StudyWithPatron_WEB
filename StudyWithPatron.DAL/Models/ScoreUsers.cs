using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyWithPatron.DAL.Models 
{
    [Table("Score_user")]
    public class ScoreUsers
    {
        [Column("id_user")]
        public Guid id_user { get; set; }

        [Column("score_user")]
        public int score_user { get; set; }

        public ScoreUsers(int score_user)
        {
            this.score_user = score_user;
        }
    }
}


