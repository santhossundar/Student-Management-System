using MySql.Data.MySqlClient;

namespace Student_Management_System_v1.services
{
    public class SQLDBConnection
    {
        public MySqlConnection Connect() 
        {
            string server = "localhost";
            string DB = "bookstall";
            string userName = "root";
            string password = "password";
            string connString = "SERVER=" + server +
                "; DATABASE=" + DB +
                "; UID=" + userName +
                "; PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            return conn;
        }
    }
}
