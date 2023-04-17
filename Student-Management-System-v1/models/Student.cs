using System.Collections.Generic;

namespace Student_Management_System_v1.models
{
    public class Student : IStudent
    {
        public List<string> SetInfo()
        {
            List<string> studentData = new List<string>();
            studentData.Add("StdID");
            studentData.Add("FirstName");
            studentData.Add("LastName");
            studentData.Add("DOB");
            studentData.Add("AddressNo");
            studentData.Add("AddressStreet");
            studentData.Add("AddressCity");
            
            return studentData;
        }
    }
}
