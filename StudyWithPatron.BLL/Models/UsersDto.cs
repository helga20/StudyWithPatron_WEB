using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyWithPatron.BLL.Models
{
    public class UsersDto
    {
        public Guid id { get; set; }
]
        public string login { get; set; }

        public string password { get; set; }
    }
}
