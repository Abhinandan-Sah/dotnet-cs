using System;

namespace M1_Practice;

class FileUpload
{
    static void Main()
    {
        string fileName = "report.exe";
        int fileSize = 8; // MB

        try
        {
            // 1. Validate file extension
            if (!fileName.EndsWith(".pdf"))
            {
                throw new InvalidOperationException("Invalid file type. Only PDF files are allowed.");
            }

            // 2. Validate file size
            if (fileSize > 5)
            {
                throw new ArgumentOutOfRangeException("File size exceeds the allowed limit.");
            }

            Console.WriteLine("File uploaded successfully.");
        }
        // 3. Handle exceptions
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
