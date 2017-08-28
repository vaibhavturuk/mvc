using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace mvc29jully.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("MyConnectionString")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}