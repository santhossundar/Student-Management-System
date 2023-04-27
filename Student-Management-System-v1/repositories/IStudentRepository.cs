using Student_Management_System_v1.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System_v1.repositories
{
    public interface IStudentRepository
    {
        void Add(List<string> studentModel);
    }
}
