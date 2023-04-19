using MySql.Data.MySqlClient;
using Student_Management_System_v1.services;

namespace Student_Management_System_v1.models
{
    public class Student : IStudent
    {
        private string stdID;
        private string firstName;
        private string lastName;
        private string DOB;
        private string addrNo;
        private string addrStreet;
        private string addrCity;
        private SQLDBConnection connection;
        private MySqlConnection conn;

        public Student(string stdID, 
            string firstName, 
            string lastName, 
            string DOB, 
            string addrNo, 
            string addrStreet, 
            string addrCity)
        {
            this.stdID = stdID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.DOB = DOB;
            this.addrNo = addrNo;
            this.addrStreet = addrStreet;
            this.addrCity = addrCity;
        }

        public void SaveInfo()
        {
            connection = new SQLDBConnection();
            conn = connection.Connect();
            conn.Open();

            string query = "insert into student values('"
                + stdID + "','"
                + firstName + "','"
                + lastName + "','"
                + DOB + "','"
                + addrNo + "','"
                + addrStreet + "','"
                + addrCity + "');";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteReader();
            conn.Close();
        }
    }
}
