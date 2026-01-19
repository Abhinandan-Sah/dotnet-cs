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

            for (int i = 0; i < count; i++)
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

            foreach (var item in items)
            {
                // 1. Check empty or null string
                if (string.IsNullOrWhiteSpace(item))
                    continue;

                // 2. Split by colon
                string[] s = item.Split(':');

                // 3. Validate format: must be exactly Name:Score
                if (s.Length != 2)
                    continue;

                string name = s[0].Trim();

                // 4. Validate name
                if (string.IsNullOrEmpty(name))
                    continue;

                // 5. Validate score
                if (!int.TryParse(s[1].Trim(), out int score))
                    continue;

                // 6. Apply minScore filter
                if (score >= minScore)
                {
                    students.Add(new Student(name, score));
                }
            }


            var filteredStudent = students.OrderByDescending((s) => s.Score).ThenBy(s => s.Name).ToList();

            var JsonRecordSerilized = JsonSerializer.Serialize(filteredStudent);

            Console.WriteLine("Filtered and Sorted Students in JSON format:");
            Console.WriteLine(JsonRecordSerilized);
            // foreach(var student in filteredStudent)
            // {
            //     Console.WriteLine($"Name: {student.Name}, Score: {student.Score}");
            // }

        }

    }
}