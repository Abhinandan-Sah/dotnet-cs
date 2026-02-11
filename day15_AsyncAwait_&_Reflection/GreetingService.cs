using System.Threading.Tasks;

public class GreetingService
{
    public async Task<string> GetGreetingAsync(string name)
    {
        await Task.Delay(200); // pretend network delay
        return $"Hello, {name}!";
    }
}