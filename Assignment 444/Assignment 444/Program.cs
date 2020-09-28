using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Assignment_444
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new StudentData())
            {
                var student = new Student { StudentId = 1, FirstName = "Gerald", LastName = "Howzer", DateOfBirth = DateTime.Now };

                ctx.students.Add(student);
                ctx.SaveChanges();
            }
            
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }

}
