using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student_Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string ClassName { get; set; }
        public int RollNo { get; set; }
        public decimal Precentage { get; set; }

    }
}