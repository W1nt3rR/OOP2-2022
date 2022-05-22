using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2V7_2
{
    public class DB
    {
        public OleDbConnection connection = new OleDbConnection();
        private OleDbCommand command;

        public DB()
        {
            connection.ConnectionString = ; //connection shit
            command = connection.CreateCommand();
        }

        // CRUD
        // Create
        public bool Create(Student student)
        {
            try
            {
                //otvaranje konekcije
                connection.Open();
                string sql = $"INSERT INTO student VALUES('${student.Ime}', '${student.Prezime}', '${student.Telefon}', '${student.GodinaStudija}')";
                command.CommandText = sql;
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (OleDbException ex)
            {
                if (connection != null)
                    connection.Close();
                //throw;
            }
        }

        // Read

        public DataTable Read()
        {
            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                string sql = "SELECT * FROM student";
                command.CommandText= sql;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                da.Fill(dt);
                connection.Close();
            }
            catch (Exception)
            {
                if (connection != null)
                    connection.Close();
            }

            return dt;
        }
        // Update
    }
}
