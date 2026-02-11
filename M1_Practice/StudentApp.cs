namespace M1_Practice
{

    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public int Marks { get; set; }
    }

    public class StudentUtility
    {
        public Dictionary<string, string> GetStudentDetails(string id)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            foreach (var kv in StudentApp.studentDetails)
            {
                if (kv.Value.Id == id)
                {
                    result[id] = kv.Value.Name + "_" + kv.Value.Course;
                    return result;
                }
            }
            return result;
        }

        public Dictionary<string, Student> UpdateStudentMarks(string id, int marks)
        {
            Dictionary<string, Student> result = new Dictionary<string, Student>();

            foreach (var kv in StudentApp.studentDetails)
            {
                if (kv.Value.Id == id)
                {
                    kv.Value.Marks = marks;
                    result[id] = kv.Value;
                    return result;
                }
            }
            return result;
        }
    }


    public class StudentApp
    {
        public static Dictionary<int, Student> studentDetails = new Dictionary<int, Student>();

        public static void Main()
        {
            studentDetails.Add(1, new Student { Id = "ST01", Name = "Alice", Course = "DataScience", Marks = 80 });
            studentDetails.Add(2, new Student { Id = "ST02", Name = "Bob", Course = "AI", Marks = 75 });

            StudentUtility util = new StudentUtility();

            while (true)
            {
                Console.WriteLine("1. Get Student Details");
                Console.WriteLine("2. Update Marks");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter your choice");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Enter the student id");
                    string id = Console.ReadLine();

                    var res = util.GetStudentDetails(id);

                    if (res.Count == 0)
                        Console.WriteLine("Student id not found");
                    else
                    {
                        foreach (var item in res)
                            Console.WriteLine(item.Key + "   " + item.Value);
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter the student id");
                    string id = Console.ReadLine();

                    Console.WriteLine("Enter the marks");
                    int marks = int.Parse(Console.ReadLine());

                    var res = util.UpdateStudentMarks(id, marks);

                    if (res.Count == 0)
                        Console.WriteLine("Student id not found");
                    else
                    {
                        foreach (var item in res)
                            Console.WriteLine(item.Key + "   " + item.Value.Marks);
                    }
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Thank you");
                    break;
                }
            }
        }
    }


}