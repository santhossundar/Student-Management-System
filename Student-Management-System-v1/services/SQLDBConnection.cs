using MySql.Data.MySqlClient;

namespace Student_Management_System_v1.services
{
    public class SQLDBConnection
    {
        public MySqlConnection Connect() 
        {
            string server = "localhost";
            string DB = "student_db";
            string userName = "root";
            string password = "toor";
            string connString = "SERVER=" + server +
                "; DATABASE=" + DB +
                "; UID=" + userName +
                "; PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }
    }
}
