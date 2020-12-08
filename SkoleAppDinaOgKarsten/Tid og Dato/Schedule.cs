using System;
using System.Collections.Generic;
using System.Text;
using SkoleAppDinaOgKarsten.Skole;
using SkoleAppDinaOgKarsten.Mennesker;

namespace SkoleAppDinaOgKarsten.Tid_og_Dato
{
   public class Schedule
    {
        //En liste over tid og fag.
        //Vite klokkeslett rommet er opptatt - 9 = occupied 10 = available.
        //Session Kl09 = Session1,
        //Sesssion Kl10 = null;
        int[] Monday;
        //Weekday[] _Days = Weekday.add(Monday);

        public List<Session> _sessions;
        public List<Session> _scheduledSessions;

        public Schedule()
        {
            _sessions = new List<Session>();
            _scheduledSessions = new List<Session>();
        }
        public void AddSession(Session session)
        {
            _sessions.Add(session);
        }

        //Class day Må vite dager den gjelder. Mandag - Fredag.
        public void FillUpSchedule()
        {
            Monday = new int[4];
          
            for (int i = 0; i < Monday.Length; i++)
            {
                
                if (Monday[i] == 0)
                {
                    Session newSession = _sessions[0];
                    newSession._time = 9+i;
                    _scheduledSessions.Add(newSession);
                    Monday[0] = 1;
                    i++;
                }
                if(Monday[i] == 1)
                {
                    i++;
                }
               
            }
        }
        public string StudentScheduel() 
        {
            return null;
        }
        public string TeacherScheduel()
        {
            return null;
        }
    }
}
