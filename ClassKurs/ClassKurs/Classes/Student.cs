using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Student : User
    {
        public Student():base()
        {

        }
        public Student(string n,string s):base(n,s)
        {

        }
        public override List<Course> CoursesToList()
        {
            return this.courses;
        }

        public void joinCourse(Course course)
        {
            course.students.Add(this);
            this.courses.Add(course);
        }
    }
}
