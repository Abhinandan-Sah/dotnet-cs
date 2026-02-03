namespace M1_Practice
{
    public class FileWriter
    {
        public static void Main()
        {
            string filepath = @"C:\Users\abhin\OneDrive\Desktop\Development\dotnet\M1_Practice\ExceptionHandling\text.txt";

            using(StreamWriter streamWriter = new StreamWriter(filepath, append: true)) // this code will create a file if it doesn't exist
            {
                streamWriter.WriteLine("How are you");
            }
        }
    }
}