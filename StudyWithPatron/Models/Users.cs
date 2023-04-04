using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyWithPatron.Models
{

    public class Users
    {
        [Column("id")]
        [Required]
        public int id { get; set; }

        [Column("login")]
        public string login { get; set; }

        [Column("password")]
        public string password { get; set; }

        public Users(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
    }
}
