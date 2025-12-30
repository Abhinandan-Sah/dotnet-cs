using System.Text.RegularExpressions;
using day9_extension;
class Program
{
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

        var collection = new MyCollection();
        collection.Add("Apple");
        collection.Add(123);
        collection.Add(true);
        collection.PrintAll();


        #endregion
    }
}