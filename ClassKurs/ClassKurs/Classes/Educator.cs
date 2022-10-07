using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Educator : User
    {
        public Educator() : base()
        {

        }

        public Educator(string n,string s):base(n,s)
        {

        }
        public override List<Course> CoursesToList()
        {
            return this.courses;
        }

        public void CreateCourse(Course course)
        {
            course.educator = this;
            this.courses.Add(course);  
        }
    }
}
