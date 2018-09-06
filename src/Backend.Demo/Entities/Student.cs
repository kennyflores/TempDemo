using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Demo.Entities
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public int StudentId{ get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
    }
}
