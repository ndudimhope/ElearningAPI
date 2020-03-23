using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Data.Entities
{
    public class Course
    {
        public Course()
        {
            Enrollments = new List<Enrollment>();
            CourseInstructor = new Instructor();
            
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Double Duration { get; set; }
        public string Description { get; set; }

        public Instructor CourseInstructor { get; set; }
        
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
