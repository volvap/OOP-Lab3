using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mytest
{   
    [Serializable]
    public class Student : Human
    {
        public int Scholarship;
        public University university;

        public Student()
        {

        }

        public Student(ref University un)
        {
            university = un;
        }

        public void study()
        {

        }
        
    }
}
