namespace M1_Practice
{
    class InputHandler
{
    static void Main()
    {
        // TODO:
        // 1. Read input from user
        int input;
        Console.WriteLine("Enter a number: ");
        // 2. Handle invalid numeric input
        while(!int.TryParse(Console.ReadLine(), out input))
            {
        // 3. Keep asking until valid number is entered
                Console.WriteLine("Invalid Input. Not a number");
            }
            Console.WriteLine($"You entered: {input}");
    }
}
}