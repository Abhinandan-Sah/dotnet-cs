using day6.InterfaceExample;
using day6.ExamManagement;
using MultipleInheritanceInterface;

namespace day6_Interface_others
{
    public class Program
    {
        public static void Main()
        {
            #region Interface.cs
            // IPrint iprint = new Document("Maze Runner");
            // iprint.print();
            #endregion

            #region ExamAssignment.cs, HOD.cs, Invigilator.cs, Exam.cs
            // var hod = new HOD(1, "Dr. Smith", 1);
            // hod.Display();
            // var invigilator = new Invigilator(101, "Mr. Johnson");
            // var exam = new Exam(1001, "Mathematics",hod.hodId, "Room 101", new DateTime(2024, 12, 15), new TimeSpan(2, 0, 0));
            // var examAssignment = new ExamAssignment(hod.hodId, exam.examId, invigilator.invigilatorId);
            // Console.WriteLine($"Exam: {exam.subject}, Date: {exam.examDate.ToShortDateString()}, Time: {exam.time.TotalHours} hours, Assigned Invigilator ID: {examAssignment.invigilatorId}");
            #endregion

            #region Complete Exam Management System - HOD Scheduling Exams
            Console.WriteLine("=== EXAM MANAGEMENT SYSTEM ===\n");

            // Create Department
            var csDepartment = new Department(1, "Computer Science", 1);
            csDepartment.DisplayDepartmentInfo();

            // Create HOD
            var hod = new HOD(1, "Dr. Smith", csDepartment.DepartmentId);
            Console.WriteLine();
            hod.Display();

            // Create Students
            var student1 = new Student(1001, "John Doe", "john@example.com", csDepartment.DepartmentId, 5, "CS2023001");
            var student2 = new Student(1002, "Jane Smith", "jane@example.com", csDepartment.DepartmentId, 5, "CS2023002");
            var student3 = new Student(1003, "Bob Wilson", "bob@example.com", csDepartment.DepartmentId, 3, "CS2023003");

            // Add students to department
            Console.WriteLine();
            csDepartment.AddStudent(student1.StudentId);
            csDepartment.AddStudent(student2.StudentId);
            csDepartment.AddStudent(student3.StudentId);

            // Create Semesters
            var semester5 = new Semester(1, 5, new DateTime(2025, 1, 1), new DateTime(2025, 5, 31), "2024-2025");
            var semester3 = new Semester(2, 3, new DateTime(2025, 1, 1), new DateTime(2025, 5, 31), "2024-2025");

            // Create Exam Schedule
            var examSchedule = new ExamSchedule();
            examSchedule.AddSemester(semester5);
            examSchedule.AddSemester(semester3);

            // Create Invigilators
            var invigilator1 = new Invigilator(101, "Mr. Johnson");
            var invigilator2 = new Invigilator(102, "Ms. Williams");
            var invigilator3 = new Invigilator(103, "Dr. Brown");

            // HOD schedules exams for Semester 5
            Console.WriteLine("\n--- HOD Scheduling Exams for Semester 5 ---");
            var exam1 = new Exam(2001, "Data Structures", hod.hodId, "Room 101", new DateTime(2025, 5, 5), new TimeSpan(3, 0, 0));
            var exam2 = new Exam(2002, "Database Management", hod.hodId, "Room 102", new DateTime(2025, 5, 7), new TimeSpan(3, 0, 0));
            var exam3 = new Exam(2003, "Operating Systems", hod.hodId, "Room 103", new DateTime(2025, 5, 9), new TimeSpan(3, 0, 0));

            hod.ScheduleExam(examSchedule, exam1, semester5.SemesterId);
            hod.ScheduleExam(examSchedule, exam2, semester5.SemesterId);
            hod.ScheduleExam(examSchedule, exam3, semester5.SemesterId);

            // HOD schedules exams for Semester 3
            Console.WriteLine("\n--- HOD Scheduling Exams for Semester 3 ---");
            var exam4 = new Exam(2004, "Digital Logic", hod.hodId, "Room 201", new DateTime(2025, 5, 6), new TimeSpan(3, 0, 0));
            var exam5 = new Exam(2005, "Computer Networks", hod.hodId, "Room 202", new DateTime(2025, 5, 8), new TimeSpan(3, 0, 0));

            hod.ScheduleExam(examSchedule, exam4, semester3.SemesterId);
            hod.ScheduleExam(examSchedule, exam5, semester3.SemesterId);

            // HOD assigns invigilators to exams
            Console.WriteLine("\n--- HOD Assigning Invigilators ---");
            hod.AssignInvigilatorToExam(examSchedule, exam1.examId, invigilator1);
            hod.AssignInvigilatorToExam(examSchedule, exam2.examId, invigilator2);
            hod.AssignInvigilatorToExam(examSchedule, exam3.examId, invigilator3);
            hod.AssignInvigilatorToExam(examSchedule, exam4.examId, invigilator1);
            hod.AssignInvigilatorToExam(examSchedule, exam5.examId, invigilator2);

            // Display information
            Console.WriteLine();
            semester5.DisplaySemesterInfo();
            Console.WriteLine();
            semester3.DisplaySemesterInfo();

            // Display all scheduled exams
            examSchedule.DisplayAllScheduledExams();

            // Display exams by semester
            examSchedule.DisplayExamsBySemester(semester5.SemesterId);
            examSchedule.DisplayExamsBySemester(semester3.SemesterId);

            // Display all assignments
            examSchedule.DisplayAllAssignments();

            // HOD views their scheduled exams
            hod.ViewMyScheduledExams(examSchedule);

            // Display student information
            Console.WriteLine("\n=== Student Information ===");
            student1.DisplayStudentInfo();
            Console.WriteLine();
            student2.DisplayStudentInfo();
            #endregion

            #region Multiple Inheritance Using Interface.cs
            // VegEater vg = new VegEater();
            // vg.vegEater();

            // NonVegEater nv = new NonVegEater();
            // nv.nonvegEater();

            // Visitor v = new Visitor();
            // v.vegEater();
            // v.nonvegEater();
            // v.visitor();

            // solving 2 method with same name in 2 interface problem
            // IvegEater vegEAter = new Visitor();
            // vegEAter.GetTaste();

            // INonvegEater nonvegEater = new Visitor();
            // nonvegEater.GetTaste();
            #endregion

        }
    }
}