using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyWithPatron.Models
{
    [Table("ScoreUser")]
    public class ScoreUsers
    {
        [Column("id")]
        [Required]
        public int id { get; set; }

        [Column("id_user")]
        public int id_user { get; set; }

        [Column("score_user")]
        public int score_user { get; set; }

        public ScoreUsers(int score_user)
        {
            this.score_user = score_user;
        }
    }
}
