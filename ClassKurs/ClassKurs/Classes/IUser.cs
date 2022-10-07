using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public interface IUser
    {
        string name { get; set; }
        string surname { get; set; }

        List<Course> CoursesToList();//Varsayılan abstract tır.
    }
}
