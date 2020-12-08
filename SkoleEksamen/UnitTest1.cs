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
        public void checkIfRoomIsOccupied()
        {   //Check to see if the room is occupied
            var testRoom = new Classroom();
            //Kan returnere sant hvis opptatt?
            var result = testRoom.IsOccupied();
            var expected = true;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void NewTeacher()
        {
            //Check if Teacher get right name.
            var testSubject = new Subject("Norsk");
            var testHire = new Teacher("Bob", testSubject);
            var result = testHire._name;
            var expected = "Bob";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void wrongSubject()
        {
            //Test vi forventer å feile! Får ut riktig.
            var testSubject = new Subject("Matte");
            var testHire = new Teacher("Bob", testSubject);
            var result = testHire._subject._name;
            var expected = "Norsk";
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestGetTeacher()
        {
            //Test for getTecher.
            var testSubject = new Subject("Matte");
            var testHire = new Teacher("Bob", testSubject);
            var result = testHire.GetTeacher();
            var expected = testHire;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void SchoolHireTeacher()
        {
            var testSchool = new School();
            var testSubject = new Subject("Gym");
            var testTeacher = new Teacher("Frank", testSubject);
            testSchool.HireTeacher(testTeacher);
            var result = testSchool._teachers.Exists(x => x._name == "Frank" && x._subject.Equals(testSubject));
            var expected = true;
            Assert.AreEqual(expected, result);
        }
    }
}