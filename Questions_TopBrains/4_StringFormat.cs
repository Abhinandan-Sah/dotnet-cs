using System.IO.Pipelines;
using System.Text.Json;

namespace Questions_TopBrains
{
    public record Student(string Name, int Score);
    public class StringFormat
    {
        public static void StringFormatAnswer()
        {
            Console.Write("Enter number of items: ");
            int count;

            while (!int.TryParse(Console.ReadLine(), out count) || count < 0)
            {
                Console.WriteLine("Invalid number. Enter a non-negative integer.");
            }

            string[] items = new string[count];

            for(int i=0; i<count; i++)
            {
                Console.Write($"Enter item {i + 1} (Name:Score): ");
                items[i] = Console.ReadLine();
            }

            int minScore;
            Console.Write("Enter minimum score to filter: ");
            while (!int.TryParse(Console.ReadLine(), out minScore) || minScore < 0)
            {
                Console.WriteLine("Invalid number. Enter a non-negative integer.");
            }
            List<Student> students = new List<Student>();
            foreach(var item in items)
            {
                string[] s= item.Split(':');
                string nam =s[0];
                int score = int.Parse(s[1]);
                if (score >= minScore)
                {
                    students.Add(new Student(nam, score));
                }
            }

            var filteredStudent = students.OrderByDescending((s)=>s.Score).ThenBy(s=>s.Name).ToList();

            var JsonRecordSerilized = JsonSerializer.Serialize(filteredStudent);
            
            Console.WriteLine("Filtered and Sorted Students in JSON format:");
            foreach(var student in filteredStudent)
            {
                Console.WriteLine($"Name: {student.Name}, Score: {student.Score}");
            }

        }

    }
}