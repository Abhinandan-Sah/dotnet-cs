using System.Text.RegularExpressions;
using day9_extension;
using day10_Serialization_Delegate;
using System.Text.Json;
using System.Runtime.CompilerServices;
class Program
{
    // class Student
    // {
    //     public int StudentId { get; set; }
    //     public string? StudentName { get; set; }
    //     public string? CourseName { get; set; }
    // }
    public static void Main()
    {
        #region day9_extension
        //    string s = "madam";
        //    bool result = s.CheckPalindrome();
        //    Console.WriteLine(result);

        //Regex
        //    string input = "Error: TIMEOUT while calling API";
        //     string pattern = @"timeout";

        //     var rx = new Regex(
        //         pattern,
        //         RegexOptions.IgnoreCase,
        //         TimeSpan.FromMilliseconds(0.1) // match timeout
        //     );

        //     Console.WriteLine(rx.IsMatch(input) ? "Found" : "Not Found");

        // Garbage Collection
        // var list = new List<byte[]>();

        // for (int i = 0; i < 1000; i++)
        // {
        //     list.Add(new byte[1024]); // Allocate 1 KB arrays 
        //     Console.WriteLine($"Allocated {i + 1} KB"); // Log allocation 
        //     Console.WriteLine("Total Memory: " + GC.GetTotalMemory(forceFullCollection: false) + " bytes");

        // }

        // BigBoy bigBoy = new BigBoy();

        // try
        // {
        //     bigBoy Names = new List<string> { "Alice", "Bob", "Charlie" };



        // }catch (Exception ex)
        // {
        //     Console.WriteLine($"An error occurred: {ex.Message}");
        // }

        // var collection = new MyCollection();
        // collection.Add("Apple");
        // collection.Add(123);
        // collection.Add(true);
        // collection.PrintAll();
        #endregion

        #region day10_Serialization
        // var weatherForecast = new WeatherForecast
        // {
        //     Date = DateTime.Parse("2019-08-01"),
        //     TemperatureCelsius = 25,
        //     Summary = "Hot"
        // };

        // string jsonString = JsonSerializer.Serialize(weatherForecast);

        // Console.WriteLine(jsonString);

        ///<summary>
        /// Delegate Example
        /// </summary>
        // ExampleOfDelegate example = new ExampleOfDelegate();
        // example.DelegateEx1();

        // PrintingCompany printingCompany = new PrintingCompany();
        // printingCompany.CustomerChoicePrintMessage  = new PrintMessage(HappyNewYear);
        // printingCompany.Print("Ram");

        // myDelegate d = MultiCastDelegate.Method1;
        // d+=MultiCastDelegate.Method2;
        // d+=MultiCastDelegate.Method3;

        // d("Hello");
        #endregion

        // Create a class student which has fields: StudentId,StudentName,CourseName and add the students to the list and display the results
        // List<Student> students = new List<Student>();
        // students.Add(new Student { StudentId = 1, StudentName = "Alice", CourseName = "Mathematics" });
        // students.Add(new Student { StudentId = 2, StudentName = "Bob", CourseName = "Physics" });
        // students.Add(new Student { StudentId = 3, StudentName = "Charlie", CourseName = "Chemistry" });
        // foreach (var student in students)
        // {
        //     Console.WriteLine($"ID: {student.StudentId}, Name: {student.StudentName}, Course: {student.CourseName}");
        // }

        
        


    }



    /// 
    // private static string HappyNewYear(string message)
    // {
    //     return "Happy New Year -------- "+ message;
    // }
}