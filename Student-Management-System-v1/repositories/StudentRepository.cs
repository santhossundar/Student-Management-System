using MySql.Data.MySqlClient;
using Student_Management_System_v1.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System_v1.repositories
{
    public class StudentRepository : BaseRepository, IStudentRepository
    {
        public StudentRepository(string connectionString) 
        { 
            this.connectionString = connectionString;
        }

        public void Add(List<string> student)
        {
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);
            sqlConnection.Open();

            string query = "insert into student values('"
                + student[0] + "','"
                + student[1] + "','"
                + student[2] + "','"
                + student[3] + "','"
                + student[4] + "','"
                + student[5] + "','"
                + student[6] + "');";

            MySqlCommand mySqlCommand = new MySqlCommand(query, sqlConnection);
            mySqlCommand.ExecuteReader();
        }
    }
}
