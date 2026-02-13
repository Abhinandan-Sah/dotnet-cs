// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class EmailValidation
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter email: ");
        string email = Console.ReadLine();
        try{
            
        if(string.IsNullOrWhiteSpace(email)){
            throw new ArgumentException("Null or empty email");
        }
        
       
        int cnt = 0;
        foreach (var c in email)
        {
            if (c == '@')
            {
                cnt++;
            }
        }

        if (cnt != 1 || email[0] == '.' || email[0] == '@' || email[email.Length - 1] == '@')
        {
            throw new ArgumentException("Invalid email");
        }

        foreach (var c in email)
        {
            if (c == ' ')
            {
                throw new ArgumentException("Invalid email");
            }
        }
         
        string[] arr = email.Split('@');
        string firstPart = arr[0];
        string secondPart = arr[1];
        

        if(firstPart.Length <=0 || secondPart.Length <=0 ){
            throw new ArgumentException("Invalid email");
        }
        
        int dotCount = 0;
        foreach (var c in secondPart)
        {
            if (c == '.')
            {
                dotCount++;
            }
        }

        if (dotCount == 0 || secondPart[0] == '.' || secondPart[secondPart.Length - 1] == '.')
        {
            throw new ArgumentException("Invalid email");
        }

        Console.WriteLine("Valid email");
        
        
         
         
         
        }
        catch(Exception ex){
            Console.WriteLine("Error: "+ex.Message);
        }
        
        
    }
}