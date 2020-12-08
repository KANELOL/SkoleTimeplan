using System;
using System.Collections.Generic;
using System.Text;
using SkoleAppDinaOgKarsten.Tid_og_Dato;
using SkoleAppDinaOgKarsten.Skole;

namespace SkoleAppDinaOgKarsten.Mennesker
{
   public class Teacher
    {
        public String _name;
        public  Subject _subject;
        public Schedule _schedule;
        bool _isAvailable;

        public Teacher(String name, Subject subject)
        {
            _name = name;
            _subject = subject;
        }

        public Teacher GetTeacher()
        {
            return this;
        }

        public bool IsAvailable()
        {
            _isAvailable = true;
            return _isAvailable;
        }
    }
}
