using System;
using System.Collections.Generic;
using System.Text;
using SkoleAppDinaOgKarsten.Tid_og_Dato;
using SkoleAppDinaOgKarsten.Mennesker;

namespace SkoleAppDinaOgKarsten.Skole
{
   public class Classroom
    {
        String _roomName;
        Teacher _classTeacher;
        Subject _currentSubject;
        Schedule _roomSchedule;
        int _capacity;
        SchoolClass _currentClass;
        bool isAvailable;

        public Classroom(int capacity)
        {
            //_classTeacher = _currentClass._teacher;
            _capacity = capacity;
        }

        public bool  IsAvailable()
        {
            isAvailable = true;
            return isAvailable;
        }
    }
}
