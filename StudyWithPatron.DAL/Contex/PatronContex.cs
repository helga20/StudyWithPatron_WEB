using Npgsql;
using System;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace StudyWithPatron.DAL.Contex
{
    public class PatronContext
    {
        public NpgsqlConnection CreateConnection()
        {
            string connectionString = "Host=127.0.0.1;Port=5432;User Id=postgres;Password=123123;Database=patron;CommandTimeout = 150;";
            NpgsqlConnection marketConnection = new NpgsqlConnection(connectionString);
            return marketConnection;
        }

    }

}
