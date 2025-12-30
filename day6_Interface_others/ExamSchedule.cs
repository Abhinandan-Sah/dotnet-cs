namespace day6.ExamManagement
{
    public class ExamSchedule
    {
        private List<Exam> exams;
        private List<ExamAssignment> examAssignments;
        private List<Semester> semesters;

        public ExamSchedule()
        {
            exams = new List<Exam>();
            examAssignments = new List<ExamAssignment>();
            semesters = new List<Semester>();
        }

        public void AddSemester(Semester semester)
        {
            semesters.Add(semester);
            Console.WriteLine($"Semester {semester.SemesterNumber} added to the schedule.");
        }

        public void ScheduleExam(Exam exam, int semesterId)
        {
            exams.Add(exam);
            var semester = semesters.Find(s => s.SemesterId == semesterId);
            if (semester != null)
            {
                semester.AddExam(exam.examId);
                Console.WriteLine($"Exam '{exam.subject}' scheduled for {exam.examDate.ToShortDateString()} at {exam.location}.");
            }
            else
            {
                Console.WriteLine("Semester not found!");
            }
        }

        public void AssignInvigilator(int hodId, int examId, int invigilatorId)
        {
            var exam = exams.Find(e => e.examId == examId);
            if (exam != null)
            {
                var assignment = new ExamAssignment(hodId, examId, invigilatorId);
                examAssignments.Add(assignment);
                Console.WriteLine($"Invigilator {invigilatorId} assigned to Exam {examId}.");
            }
            else
            {
                Console.WriteLine("Exam not found!");
            }
        }

        public void DisplayAllScheduledExams()
        {
            Console.WriteLine("\n=== All Scheduled Exams ===");
            foreach (var exam in exams)
            {
                Console.WriteLine($"Exam ID: {exam.examId}, Subject: {exam.subject}, Date: {exam.examDate.ToShortDateString()}, Location: {exam.location}");
            }
        }

        public void DisplayExamsBySemester(int semesterId)
        {
            var semester = semesters.Find(s => s.SemesterId == semesterId);
            if (semester != null)
            {
                Console.WriteLine($"\n=== Exams for Semester {semester.SemesterNumber} ===");
                foreach (var examId in semester.ExamIds)
                {
                    var exam = exams.Find(e => e.examId == examId);
                    if (exam != null)
                    {
                        Console.WriteLine($"Exam ID: {exam.examId}, Subject: {exam.subject}, Date: {exam.examDate.ToShortDateString()}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Semester not found!");
            }
        }

        public void DisplayAllAssignments()
        {
            Console.WriteLine("\n=== All Exam Assignments ===");
            foreach (var assignment in examAssignments)
            {
                var exam = exams.Find(e => e.examId == assignment.examId);
                if (exam != null)
                {
                    Console.WriteLine($"Exam: {exam.subject}, Exam ID: {assignment.examId}, Invigilator ID: {assignment.invigilatorId}, HOD ID: {assignment.hodId}");
                }
            }
        }

        public List<Exam> GetExamsByHOD(int hodId)
        {
            return exams.Where(e => e.hodId == hodId).ToList();
        }
    }
}
