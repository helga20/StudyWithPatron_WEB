global using StudyWithPatron.DAL.Contex;
using Npgsql;
using System.Data;

namespace StudyWithPatron.BLL.Services
{
    public class PatronService
    {
        PatronContext _context = new PatronContext();
        public DataTable GetAllInfoUser()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var con = _context.CreateConnection())
                {
                    var select = new NpgsqlCommand($"SELECT users.id, users.login, users.password,  score_bombs.score_bomb + score_user.score_user AS result_score FROM \"dev\".users INNER JOIN \"dev\".score_bombs ON users.id = score_bombs.id_user INNER JOIN \"dev\".score_user ON users.id = score_user.id_user");
                    select.Connection = con;
                    con.Open();
                    var reader = select.ExecuteReader();
                    dt.Load(reader);
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dt;
        }
    }
}