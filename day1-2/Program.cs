using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace dotnet;
class Program
{

    static void Main(string[] args)
    {
        // int a = 20;
        // int b = 30;
        // Console.WriteLine("Sum of a and b = "+ (a+b));
        // Console.WriteLine("Enter your name: ");
        // string? name = Console.ReadLine();

        // Console.WriteLine("Hello, " + name + "!");
        // int age=20;
        // if (age >= 18)
        // {
        //     Console.WriteLine("Eligible");
        // }
        // else
        // {
        //     Console.WriteLine("Not Eligible");
        // }
        // Console.WriteLine("Enter a number: ");
        // // int? n = int.Parse(Console.ReadLine());
        // int n = Convert.ToInt32(Console.ReadLine());
        // if(n>2 && n % 2 == 0)
        // {
        //     Console.WriteLine(n+" isn't prime number");
        //     return;
        // }
        // for(int i=3; i<n; i+=2)
        // {
        //     if (n % i == 0)
        //     {
        //         Console.WriteLine(n+" isn't prime number");
        //         break;
        //     }

        // }

        // Console.WriteLine(n+" is prime number");

        // Console.WriteLine("Enter a string for number: ");
        // string?  input= Console.ReadLine();

        // if(int.TryParse(input, out int age))
        // {
        //     bool isAdult = age >=18;
        //     Console.WriteLine("Adult? "+ isAdult);
        // }
        // else
        // {
        //     Console.WriteLine("Invalid age. Please enter a whole number");
        // }

        // Console.WriteLine("Enter feet to Covert: ");
        // double? feet = double.Parse(Console.ReadLine());
        // Console.WriteLine(feet*30.48); 

        // importing Calc class from Calc.cs
        //     Calc myCalc = new Calc();

        // Console.WriteLine("Enter a number to check:");
        // Using int.TryParse is safer than Convert.ToInt32 to avoid crashes if user enters text
        // if (int.TryParse(Console.ReadLine(), out int input))
        // {
        //     bool result = myCalc.IsEven(input);
        //     Console.WriteLine($"Is {input} even? {result}");
        // }
        // else
        // {
        //     Console.WriteLine("Invalid input. Please enter a number.");
        // }
        // Console.ReadKey();


        #region EvenOddCheckLoop
        // Console.WriteLine("Enter a number to Check Even or Odd and Press q or Q to exit");
        // Calc calc = new Calc();
        // string? input = Console.ReadLine();
        // bool flag = false;
        // int num;
        // string checkResult = string.Empty;

        // while(num!="q" || num != "Q")
        // {
        //     num=(int.TryParse(input, out int number));
        //     flag = calc.IsEven(num)? "Even": "odd";
        //     Console.WriteLine(flag);
        //     Console.WriteLine("Enter a number to Check Even or Odd and Press q or Q to exit");
        //     string? input = Console.ReadLine();
        // }
        #endregion

        // Practice practice = new Practice();
        Calc myCalc = new Calc();
        myCalc.CheckHeight();
        myCalc.LargestOfThree();

    }
}