namespace day6.ExamManagement
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }
        public int CurrentSemester { get; set; }
        public string RollNumber { get; set; }

        public Student(int studentId, string name, string email, int departmentId, int currentSemester, string rollNumber)
        {
            StudentId = studentId;
            Name = name;
            Email = email;
            DepartmentId = departmentId;
            CurrentSemester = currentSemester;
            RollNumber = rollNumber;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student ID: {StudentId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Roll Number: {RollNumber}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Department ID: {DepartmentId}");
            Console.WriteLine($"Current Semester: {CurrentSemester}");
        }
    }
}
