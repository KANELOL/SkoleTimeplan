using System;
using System.Collections.Generic;
using System.Text;

namespace SkoleAppDinaOgKarsten.Skole
{
    public class Subject
    {
        public String _name;
        public int _classHours;

        public Subject(String name, int classHours)
        {
            _classHours = classHours;
            _name = name;
        }
    }
}
