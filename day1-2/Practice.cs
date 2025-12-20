using System;
using System.Runtime.CompilerServices;

namespace dotnet;
public class Practice
{
    public void CheckHeight()
    {
        Console.Write("Enter height in cm: ");
        string? input = Console.ReadLine();

        if(int.TryParse(input, out int h))
        {
            if(h<150) Console.WriteLine("Dwarf");
            if(h>=150 && h<165) Console.WriteLine("Average");
            if(h>=165 && h<=190) Console.WriteLine("Tall");
            if(h>190) Console.WriteLine("Abnormal");
        }
        else
        {
            Console.WriteLine("Error");
        }
    }

}