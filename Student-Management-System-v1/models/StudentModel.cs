using MySql.Data.MySqlClient;
using Student_Management_System_v1.repositories;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Student_Management_System_v1.models
{
    public class StudentModel
    {
        private string stdID;
        private string firstName;
        private string lastName;
        private string DOB;
        private string addrNo;
        private string addrStreet;
        private string addrCity;

        public string StdID { get => stdID; set => stdID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string DOB1 { get => DOB; set => DOB = value; }
        public string AddrNo { get => addrNo; set => addrNo = value; }
        public string AddrStreet { get => addrStreet; set => addrStreet = value; }
        public string AddrCity { get => addrCity; set => addrCity = value; }

        /*
        public void GetData()
        {
            connection.Connect();
            string query = "select * from student;";
            reader = connection.ExcecuteCommand(query);

            connection.DisConnect();
        }
        */
    }
}
