using EnumsNET;
using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Data.Entities
{
    public class Instructor
    {
        public Instructor()
        {
            Courses = new List<Course>();
        }
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Enums.Gender Gender{ get; set; }

        public ICollection<Course> Courses;
    }
}
