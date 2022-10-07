using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public static class CourseManager
    {
        public static List<Course> courses = new List<Course>();
        public static void CourseList()
        {
            courses.ForEach(x => Console.WriteLine($"{x.Name} {x.StartDate} {x.endDate} {x.totalHour} {x.weeklyHour} {x.educator.name}  {x.educator.surname} {x.students.Count}"));
        }
    }
}
