using ExamSchedule.Data;
namespace ExamSchedule
{
    public class Program
    {
        public static void Main()
        {
            var students = DataBank.GetStudents();
            var sessions = DataBank.GetSessions();
        }
    }
}