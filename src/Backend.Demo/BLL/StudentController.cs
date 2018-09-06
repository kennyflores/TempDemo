using Backend.Demo.DAL;
using Backend.Demo.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Demo.BLL
{
    [DataObject]
    public class StudentController
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Student> ListAllStudents()
        {
            using (var context = new MyDatabaseContext())
            {
                return context.Students.ToList();
            }
        }
    }
}
