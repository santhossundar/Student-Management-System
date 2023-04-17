using MySql.Data.MySqlClient;
using System.Data;

namespace Student_Management_System_v1.services
{
    public class DBConnection
    {
        private readonly string server = "localhost";
        private readonly string DB = "student_db";
        private readonly string username = "root";
        private readonly string password = "toor";
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataReader reader;

        public MySqlConnection Connect() 
        {
            string connectionString = "SERVER=" + server +
            "; DATABASE=" + DB +
            "; UID=" + username +
            "; PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

            return connection;
        }

        public void DisConnect()
        {
            connection.Close();
        }

        public MySqlDataReader ExcecuteCommand(string query)
        {
            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();
        
            return reader;
        }

        public DataSet ExcecuteAdapter(string query)
        {
            DataSet dataSet = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query,connection);
            adapter.Fill(dataSet, "student");

            return dataSet;
        }
    }
}
