using System;
using System.Collections.Generic;
using System.Text;
using SkoleAppDinaOgKarsten.Tid_og_Dato;
using SkoleAppDinaOgKarsten.Mennesker;

namespace SkoleAppDinaOgKarsten.Skole
{
    public class Session
    {
        public  Classroom _room;
        public Teacher _teacher;
        public Subject _subject;
        public int _time;

        public Session(Classroom classroom, Teacher teacher, Subject subject)
        {
            _room = classroom;
            _teacher = teacher;
            _subject = subject;
        }
    }
}
