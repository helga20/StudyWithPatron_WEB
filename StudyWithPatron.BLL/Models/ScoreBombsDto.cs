using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyWithPatron.BLL.Models
{
    public class ScoreBombsDto
    {
        public Guid id_user { get; set; }

        public int score_bomb { get; set; }

        public int id_bomb { get; set; }
    }
}
