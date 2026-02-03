namespace M1_Practice;

class FileReader
{
    public static void Main()
    {
        string filePath = @"C:\Users\abhin\OneDrive\Desktop\\dotnet\M1_Practice\ExceptionHandling\data.txt";
        StreamReader? reader = null;

        try
        {
        // 1. Read file content
            // using(StreamReader streamReader = new StreamReader(filePath))
            // {
            //     string content = streamReader.ReadToEnd();
            //     Console.WriteLine(content);
            // }

            reader = new StreamReader(filePath);
            string content = reader.ReadToEnd();
            Console.WriteLine(content);
        }
        // 2. Handle FileNotFoundException
catch (FileNotFoundException)
{
    Console.WriteLine("File not found.");
}

catch (DirectoryNotFoundException)
{
    Console.WriteLine("Directory not found.");
}
        // 3. Handle UnauthorizedAccessException
catch (UnauthorizedAccessException)
{
    Console.WriteLine("Access denied.");
}

        finally
        {
            // 4. Ensure resource is closed properly
            if (reader != null)
            {
                reader.Dispose();
                Console.WriteLine("File Closed Successfully.");
            }
        }

    }
}