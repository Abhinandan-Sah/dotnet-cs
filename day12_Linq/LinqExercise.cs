namespace day12_Linq
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RollNo { get; set; }
        public int Marks { get; set; }

        public static decimal AverageMarks(List<Student> students)
        {
            var marks = from student in students
                        select student.Marks;
            
            // foreach (var m in marks.ToList())
            // {
            //     Console.WriteLine(m);
            // }

            return CalculateAvg(marks.ToList());
        }

        private static decimal CalculateAvg(List<int> marks)
        {
            decimal sum = 0;
            foreach (var mark in marks)
            {
                sum += mark;
            }
            return sum / marks.Count;
        }

        public static int MaxMark(List<Student> students)
        {
            var MaxMark = (from student in students
                           select student.Marks).Max();
            return MaxMark;
        }
        
    }
}