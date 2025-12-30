namespace day6.ExamManagement
{
    public class Semester
    {
        public int SemesterId { get; set; }
        public int SemesterNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string AcademicYear { get; set; }
        public List<int> ExamIds { get; set; }

        public Semester(int semesterId, int semesterNumber, DateTime startDate, DateTime endDate, string academicYear)
        {
            SemesterId = semesterId;
            SemesterNumber = semesterNumber;
            StartDate = startDate;
            EndDate = endDate;
            AcademicYear = academicYear;
            ExamIds = new List<int>();
        }

        public void AddExam(int examId)
        {
            if (!ExamIds.Contains(examId))
            {
                ExamIds.Add(examId);
                Console.WriteLine($"Exam {examId} added to Semester {SemesterNumber}.");
            }
            else
            {
                Console.WriteLine($"Exam {examId} already scheduled for this semester.");
            }
        }

        public void DisplaySemesterInfo()
        {
            Console.WriteLine($"Semester ID: {SemesterId}");
            Console.WriteLine($"Semester Number: {SemesterNumber}");
            Console.WriteLine($"Academic Year: {AcademicYear}");
            Console.WriteLine($"Start Date: {StartDate.ToShortDateString()}");
            Console.WriteLine($"End Date: {EndDate.ToShortDateString()}");
            Console.WriteLine($"Total Exams Scheduled: {ExamIds.Count}");
        }
    }
}
