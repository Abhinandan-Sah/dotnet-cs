using System.Data.Common;
using ExamSchedule.Model;

namespace ExamSchedule.Data
{
    public class DataBank
    {
        public static List<Student> students = new List<Student>();
        public static List<StudentSession> studentSession = new List<StudentSession>();

         static DataBank()
        {
            students.Add(new Student(){id=1, name="Abu"});
            students.Add(new Student(){id=2, name="Babu"});
            students.Add(new Student(){id=3, name="Dabu"});
            studentSession.Add(new StudentSession(){id="CSE2024", name="Computer Science"});
        }

        public static List<Student> GetStudents()
        {
            return students;
        }

        public static List<StudentSession> GetSessions()
        {
            return studentSession;
        }
    }
}