using System.Collections.Generic;
using System.Windows.Forms;

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
            // Sql code to insert the data
            MessageBox.Show("Saved");
        }
    }
}
