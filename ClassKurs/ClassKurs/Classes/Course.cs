using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Course
    {
         string name;
        public string Name { get => name;
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new ArgumentException();
                }
                name = value;
            }
        }
        public int totalHour { get; set; }
        public int weeklyHour { get; set; }
        private DateTime startDate;//Ctrl+R+E
        public DateTime endDate { get; }

        public Educator educator { get; set; }
        public List<Student> students = new List<Student>();
        public DateTime StartDate
        {
            get => startDate;
            set
            {
                if(value.Day < DateTime.Now.Day)
                {
                    throw new ArgumentException($"baslangıç tarihi  {DateTime.Now.Day} dan sonra olmalıdır");
                }
                startDate = value;
            }
        }

       

        public Course()
        {
            this.endDate = EndDateCalculate();
        }
        public Course(string name,int total_hour,int weekhour,DateTime start_date )
        {
            this.Name = name;
            this.totalHour = total_hour;
            this.weeklyHour = weekhour;
            this.startDate = start_date;
            this.endDate = EndDateCalculate();

        }

        private DateTime EndDateCalculate()
        {
            int day = (this.totalHour / this.weeklyHour)*7;
            return this.startDate.AddDays(day);
        }
    }
}
