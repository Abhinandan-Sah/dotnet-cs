namespace day12_Linq
{
    public class Program
    {
        public static void Main()
        {
            // LinqExample.LinqStudent();
            // LinqExample.LinqExample2();


            var student = new Student()
            {
                Id = 1,
                Name = "Abhin",
                RollNo = 101,
                Marks = 95
            };
            var student2 = new Student()
            {
                Id = 2,
                Name = "Asad",
                RollNo = 102,
                Marks = 85
            };
            var student3 = new Student()
            {
                Id = 3,
                Name = "Rohit",
                RollNo = 103,
                Marks = 75
            };
            var students = new List<Student>() { student, student2, student3 };
            var averageMarks = Student.AverageMarks(students);
            var MaxMark = Student.MaxMark(students);
            System.Console.WriteLine($"Average Marks: {averageMarks}");
            System.Console.WriteLine($"Max Marks: {MaxMark}");
        }
    }
}