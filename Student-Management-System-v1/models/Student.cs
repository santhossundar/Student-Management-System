using MySql.Data.MySqlClient;
using Student_Management_System_v1.services;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;

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
        private DBConnection connection = new DBConnection();
        private MySqlDataReader reader = null;

        public static List<string> stdIDList;
        public static List<string> firstNameList;
        public static List<string> lastNameList;
        public static List<string> DOBList;
        public static List<string> addrNoList;
        public static List<string> addrStreetList;
        public static List<string> addrCityList;

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

        public void GetData()
        {
            connection.Connect();
            string query = "select * from student;";
            reader = connection.ExcecuteCommand(query);

            connection.DisConnect();
            
        }

        public void SaveInfo()
        {
            connection.Connect();

            string query = "insert into student values('"
                + stdID + "','"
                + firstName + "','"
                + lastName + "','"
                + DOB + "','"
                + addrNo + "','"
                + addrStreet + "','"
                + addrCity + "');";

            connection.ExcecuteCommand(query);
            connection.DisConnect();
        }
    }
}
