using System;
using System.Threading.Tasks;
using System.Net.Http;

class Program
{
    /// <summary>
    /// This is the main program
    /// </summary>
    /// <returns></returns>
    private static readonly HttpClient _http = new HttpClient();
    static async Task Main()
    {
        /*
        await SaveAsync();                // Task (no return)
        int total = await GetTotalAsync(); // Task<int> (returns value)
        Console.WriteLine(total);

        GreetingService greetingService = new GreetingService();
        string greet = await greetingService.GetGreetingAsync("Avi");
        System.Console.WriteLine(greet);
        */

        //for FetchJsonAsync
        await FetchJsonAsync();
    }



    static async Task FetchJsonAsync()
    {

        Console.WriteLine("Status: Fetching...");
        Console.WriteLine("---- " + DateTime.Now.ToString("HH:mm:ss.fff") + " ----");
        await Task.Delay(3000);

        try
        {
            string url = "https://lpu.in/";
            string json = await _http.GetStringAsync(url);

            Console.WriteLine(json);
            Console.WriteLine("Status: Success");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            Console.WriteLine("Status: Failed");
        }
    }

    static async Task SaveAsync()
    {
        await Task.Delay(3000); // pretend we saved to DB
        Console.WriteLine("Saved!");
    }

    static async Task<int> GetTotalAsync()
    {
        await Task.Delay(3000); // pretend we calculated
        return 42;
    }
}