using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public abstract class User : IUser
    {
        public string name { get; set; }
        public string surname { get; set; }
        public List<Course> courses;
        public User()
        {
            courses = new List<Course>();
        }
        public User(string n,string s)
        {
            this.name = n;
            this.surname = s;
            courses = new List<Course>();
        }

        public abstract List<Course> CoursesToList();
    }
}
