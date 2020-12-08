using System;
using System.Collections.Generic;
using System.Text;
using SkoleAppDinaOgKarsten.Mennesker;
using SkoleAppDinaOgKarsten.Tid_og_Dato;

namespace SkoleAppDinaOgKarsten.Skole
{
   public class School
    {
        public List<Session> _sessions;
       public Schedule _schoolSchedule;
        public List<Classroom> _classrooms;
        public  List<Teacher> _teachers;
        public List<Student> _students;
        public int _capacity;

        public School()
        {
            _teachers = new List<Teacher>();
            _sessions = new List<Session>();
            _classrooms = new List<Classroom>();
            _schoolSchedule = new Schedule();
        }

        public void CreateNewRoom()
        {
            var newRoom = new Classroom(30);
            _classrooms.Add(newRoom);
        }

        public void HireTeacher(Teacher teacher)
        {
            //var newTeacher = new Teacher(teacherName, subject);
            _teachers.Add(teacher);
        }
        public void CreateSession()
        {
            Subject freeSubject = new Subject("Mock", 0);
            Classroom freeRoom = new Classroom(30);
            Teacher freeTeacher = new Teacher("StandIn", freeSubject);
            
            foreach(Classroom room in _classrooms)
            {
                if(room.IsAvailable())
                {
                    freeRoom = room;
                } 
            }
            foreach(Teacher teacher in _teachers)
            {
                if (teacher.IsAvailable())
                {
                    freeTeacher = teacher;
                    freeSubject = freeTeacher._subject;
                }
            }
            var newSession = new Session(freeRoom, freeTeacher, freeSubject);
            _sessions.Add(newSession);
        }
        public void AddSessionToSchedule()
        {
            //Vi har X sessions i timen = room+lærere/2;
            foreach(Session session in _sessions)
            {
                _schoolSchedule.AddSession(session);
            }
        }
    }
}
