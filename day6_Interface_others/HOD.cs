namespace day6.ExamManagement
{
    public class HOD
    {
        public int hodId { get; }
        public string Name { get; }
        public int DepartmentId { get; set; }

        public HOD(int hodId, string name, int departmentId)
        {
            this.hodId = hodId;
            Name = name;
            DepartmentId = departmentId;
        }

        public void Display()
        {
            Console.WriteLine($"HOD Name: {Name}");
            Console.WriteLine($"HOD ID: {hodId}");
            Console.WriteLine($"Department ID: {DepartmentId}");
        }

        // Schedule exam for a semester
        public void ScheduleExam(ExamSchedule examSchedule, Exam exam, int semesterId)
        {
            Console.WriteLine($"\nHOD {Name} is scheduling exam...");
            examSchedule.ScheduleExam(exam, semesterId);
        }

        // Assign invigilator to an exam
        public void AssignInvigilatorToExam(ExamSchedule examSchedule, int examId, Invigilator invigilator)
        {
            Console.WriteLine($"\nHOD {Name} is assigning invigilator {invigilator.Name} to exam {examId}...");
            examSchedule.AssignInvigilator(this.hodId, examId, invigilator.invigilatorId);
        }

        // View all exams scheduled by this HOD
        public void ViewMyScheduledExams(ExamSchedule examSchedule)
        {
            Console.WriteLine($"\n=== Exams Scheduled by HOD {Name} ===");
            var myExams = examSchedule.GetExamsByHOD(this.hodId);
            foreach (var exam in myExams)
            {
                Console.WriteLine($"Exam ID: {exam.examId}, Subject: {exam.subject}, Date: {exam.examDate.ToShortDateString()}, Location: {exam.location}");
            }
        }
    }
}