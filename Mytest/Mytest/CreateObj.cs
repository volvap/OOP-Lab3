using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mytest
{
    [Serializable]
    class CreateObj
    {
        string[] Sname = new string[] {"Kolya","Petya","Sasha","Andrey","Vasya","Viktor","Gleb","Nikita","Vlad" };
        string[] Sgender = new string[] { "Male" };
        string[] Suniversity = new string[] { "BSUIR","BSU","BNSU" };
        //Student student = new Student();
        List<Student> f { get; set; }

        public Student Cr(Student student, ref University university)
        {
                Random rand = new Random();
                student.Age = rand.Next(18, 30);
                student.Name = Sname[rand.Next(0, Sname.Length)];
                student.Gender = Sgender[rand.Next(0, Sgender.Length)];
                student.university.Uname = Suniversity[rand.Next(0, Suniversity.Length)];
                return student;
            
        }

       
        public List<Student> Kr(List<Student> f)
        {
            List<Student> spisok2 = new List<Student>();
            spisok2 = f;
            return spisok2;
        }

    }
}

