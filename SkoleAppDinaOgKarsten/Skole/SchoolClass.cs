using System;
using System.Collections.Generic;
using System.Text;
using SkoleAppDinaOgKarsten.Mennesker;
using SkoleAppDinaOgKarsten.Skole;
using SkoleAppDinaOgKarsten.Tid_og_Dato;

namespace SkoleAppDinaOgKarsten.Skole
{
   public class SchoolClass
    {
        public  Teacher _teacher;
        public List<Student> _students;

        public SchoolClass(Teacher teacher)
        {
            _teacher = teacher;
            _students = new List<Student>();
        } 
    }
}
