using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    class Student
    {
       public string Name;
       public string SurName;
       public double Group;
       public double Point;
       public bool IsGruated;

        public Student()
        {

        }
        public Student(string name,string surname)
        {
            Name=name;
            SurName = surname;
        }
        public Student(string name,string surname,double group,double point,bool isgruated)
        {
            Name = name;
            SurName = surname;
            Group = group;
            Point = point;
            IsGruated = isgruated;
        }

        public string Gruated()
        {
            if (IsGruated)
            {
                return "Telebe Mezun olub";
            }
            else
            {
                return "Telebe Mezun olmuyub";
            }
        }

        public string JoinExam()
        {
            if (Point>80)
            {
                return "Telebe imtahana daxil ola biler";
            }
            return "Telebe Imtahana daxil ola bilmez";
        }
    }
}
