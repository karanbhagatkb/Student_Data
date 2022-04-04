using Student_Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Student_Data
{
    public class ApplicationDbcontext:DbContext
    {
        public ApplicationDbcontext():base("Constr")
        {

        }
        public DbSet<Student>students { get; set; }

       
    }
}