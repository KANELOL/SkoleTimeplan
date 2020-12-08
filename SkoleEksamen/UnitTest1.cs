using NUnit.Framework;
using SkoleAppDinaOgKarsten;
using SkoleAppDinaOgKarsten.Skole;
using SkoleAppDinaOgKarsten.Mennesker;
using SkoleAppDinaOgKarsten.Tid_og_Dato;
namespace SkoleEksamen
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void AddRoomToSchool()
        {
            //Check to see if a classroom is added to the Schoolslist of rooms.
            var testSchool = new School();
            testSchool.CreateNewRoom();
            var expected = 1;
            var result = testSchool._classrooms.Count;
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void AddSession()
        {
            //Test for making a session.
            School testSchool = new School();
            testSchool.CreateNewRoom();
            Subject testSubject = new Subject("Arkeologi", 1);
            Teacher testTeacher = new Teacher("Kåre", testSubject);
            testSchool.HireTeacher(testTeacher);
            testSchool.CreateSession();
            var result = testSchool._sessions.Count;
            var expected = 1;
            Assert.AreEqual(expected, result);


        }
        [Test]
        public void AddSessionAndCheckSubjectName()
        {
            //Test for making a session.
            School testSchool = new School();
            testSchool.CreateNewRoom();
            Subject testSubject = new Subject("Arkeologi", 1);
            Teacher testTeacher = new Teacher("Kåre", testSubject);
            testSchool.HireTeacher(testTeacher);
            testSchool.CreateSession();
            var result = testSchool._sessions[0]._subject._name;
            var expected = "Arkeologi";
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void AddSessionToSchoolScheduleTest()
        {
            //Test for making a session.
            School testSchool = new School();
            testSchool.CreateNewRoom();
            Subject testSubject = new Subject("Arkeologi", 1);
            Teacher testTeacher = new Teacher("Kåre", testSubject);
            testSchool.HireTeacher(testTeacher);
            testSchool.CreateSession();
            testSchool.AddSessionToSchedule();
            var result = testSchool._schoolSchedule._sessions[0]._subject._name;
            var expected = "Arkeologi";
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FillUpSchoolSchedule()
        {
            //Test for filling up a Schedule.
            School testSchool = new School();
            testSchool.CreateNewRoom();
            Subject testSubject = new Subject("Arkeologi", 1);
            Teacher testTeacher = new Teacher("Kåre", testSubject);
            testSchool.HireTeacher(testTeacher);
            testSchool.CreateSession();
            testSchool.AddSessionToSchedule();
            testSchool._schoolSchedule.FillUpSchedule();
            var result = testSchool._schoolSchedule._scheduledSessions.Count;
            var expected = 4;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void checkIfRoomIsOccupied()
        {   //Check to see if the room is occupied
            var testRoom = new Classroom(30);
            //Kan returnere sant hvis opptatt?
            var result = testRoom.IsAvailable();
            var expected = true;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void NewTeacher()
        {
            //Check if Teacher get right name.
            var testSubject = new Subject("Norsk", 30);
            var testHire = new Teacher("Bob", testSubject);
            var result = testHire._name;
            var expected = "Bob";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void wrongSubject()
        {
            //Test vi forventer å feile! Får ut riktig.
            var testSubject = new Subject("Matte", 30);
            var testHire = new Teacher("Bob", testSubject);
            var result = testHire._subject._name;
            var expected = "Norsk";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestGetTeacher()
        {
            //Test for getTecher.
            var testSubject = new Subject("Matte", 30);
            var testHire = new Teacher("Bob", testSubject);
            var result = testHire.GetTeacher();
            var expected = testHire;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void SchoolHireTeacher()
        {
            var testSchool = new School();
            var testSubject = new Subject("Gym", 30);
            var testTeacher = new Teacher("Frank", testSubject);
            testSchool.HireTeacher(testTeacher);
            var result = testSchool._teachers.Exists(x => x._name == "Frank" && x._subject.Equals(testSubject));
            var expected = true;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ClassHaveATeacher()
        {
            //class has a teacher
            Subject testSubject = new Subject("Matte", 30);
            Teacher testTeacher = new Teacher("Petter", testSubject);
            SchoolClass testClass = new SchoolClass(testTeacher);
            var result = testClass._teacher;
            var expected = testTeacher;
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void ClassSubjectTimeslot()
        {
            //School - Room - Tidrommet er ledig - Finn en Klasse - Finne Lærer, elev
            //Sjekke om rommet er ledig.
            //Det er mandag kl 09. kan vi sette opp en norsk klasse på det tidspunket? 
            Subject testSubject = new Subject("Matte", 30);
            Teacher testTeacher = new Teacher("Petter", testSubject);
            SchoolClass testClass = new SchoolClass(testTeacher);
            var result = testClass._teacher;
            var expected = testTeacher;
            Assert.AreEqual(expected, result);
        }
    }
}