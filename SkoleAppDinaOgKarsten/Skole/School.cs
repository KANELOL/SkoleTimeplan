using System;
using System.Collections.Generic;
using System.Text;
using SkoleAppDinaOgKarsten.Mennesker;

namespace SkoleAppDinaOgKarsten.Skole
{
   public class School
    {
        public List<Classroom> _classrooms;
        public  List<Teacher> _teachers;
        public int _capacity;
        //List<Student> _students;
        public School()
        {
            _teachers = new List<Teacher>();
            _classrooms = new List<Classroom>();
        }


        public void CreateNewRoom()
        {
            var newRoom = new Classroom();
            _classrooms.Add(newRoom);
        }

        public void HireTeacher(Teacher teacher)
        {
            //var newTeacher = new Teacher(teacherName, subject);
            _teachers.Add(teacher);
        }
    }
}
