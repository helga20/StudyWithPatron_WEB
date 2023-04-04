using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyWithPatron.Models
{

    [Table("Score_bombs")]
    public class ScoreBombs
    {
        [Column("id")]
        [Required]
        public int id { get; set; }

        [Column("id_user")]
        public int id_user { get; set; }

        [Column("score_bomb")]
        public int score_bomb { get; set; }

        [Column("id_bomb")]
        public int id_bomb { get; set; }

        public ScoreBombs(int score_bomb, int id_bomb)
        {
            this.score_bomb = score_bomb;
            this.id_bomb = id_bomb;
        }
    }
}
