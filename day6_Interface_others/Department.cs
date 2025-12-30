namespace day6.ExamManagement
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int HodId { get; set; }
        public List<int> StudentIds { get; set; }

        public Department(int departmentId, string departmentName, int hodId)
        {
            DepartmentId = departmentId;
            DepartmentName = departmentName;
            HodId = hodId;
            StudentIds = new List<int>();
        }

        public void AddStudent(int studentId)
        {
            if (!StudentIds.Contains(studentId))
            {
                StudentIds.Add(studentId);
                Console.WriteLine($"Student {studentId} added to {DepartmentName} department.");
            }
            else
            {
                Console.WriteLine($"Student {studentId} already exists in the department.");
            }
        }

        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"Department ID: {DepartmentId}");
            Console.WriteLine($"Department Name: {DepartmentName}");
            Console.WriteLine($"HOD ID: {HodId}");
            Console.WriteLine($"Total Students: {StudentIds.Count}");
        }
    }
}
