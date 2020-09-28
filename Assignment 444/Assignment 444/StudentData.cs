using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_444
{
    public class StudentData: DbContext
    {
        public StudentData() : base()
        {
        }
        public DbSet<Student> students { get; set; }
    }
}
