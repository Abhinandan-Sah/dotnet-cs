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

        Console.WriteLine("Enter feet to Covert: ");
        double? feet = double.Parse(Console.ReadLine());
        Console.WriteLine(feet*30.48); 
    
    }
}