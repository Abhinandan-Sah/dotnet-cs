using System;

// namespace Program;
namespace dotnet;

class Calc{
    #region EvenAndOdd
    public bool IsEven(int n)
    {
        if (n % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    #endregion

    #region checkHeight
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
    #endregion

    #region Largest of Three: Take three integers and find the maximum using nested if

    public void LargestOfThree()
    {
        
        Console.WriteLine("Enter 1st no: ");
        string? i1= Console.ReadLine();

        Console.WriteLine("Enter 2nd no: ");
        string? i2= Console.ReadLine();

        Console.WriteLine("Enter 3th no: ");
        string? i3= Console.ReadLine();

        if(int.TryParse(i1, out int n1) && int.TryParse(i2, out int n2) && int.TryParse(i3, out int n3))
        {
            if(n1>n2 && n1 > n3)
            {
                Console.WriteLine(n1+" is Greatest.");
            }
            else if(n2>n1 && n2 > n3)
            {
                Console.WriteLine(n2+" is Greatest.");
            }
            else
            {
                Console.WriteLine(n3+" is Greatest.");
            }
        }
        else
        {
            Console.WriteLine("Error");
        }

    }
    #endregion

    #region Leap Year Checker
    public void CheckLeapYear()
    {
        Console.WriteLine("Enter year to check if leap year or not?");
        string? inp=Console.ReadLine();

        if(int.TryParse(inp, out int year))
        {
            if(year%400==0 || (year%4==0 && year % 100 != 0))
            {
                Console.WriteLine(year + " is a leap year.");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year.");
            }
        }
        else
        {
            Console.WriteLine("Error");
        }
    }

    #endregion

    #region Quadratic Equation
    public void CheckQuadraticEquation()
    {
        
       int a; 

        Console.WriteLine("Enter a: ");

        while (!int.TryParse(Console.ReadLine(), out a)) {
            Console.WriteLine("Invalid input. Please enter a number:");
        }
        
       int b; 

        Console.WriteLine("Enter b: ");

        while (!int.TryParse(Console.ReadLine(), out b)) {
            Console.WriteLine("Invalid input. Please enter a number:");
        }

        int c; 

        Console.WriteLine("Enter c: ");

        while (!int.TryParse(Console.ReadLine(), out c)) {
            Console.WriteLine("Invalid input. Please enter a number:");
        }

        double d = b*b -4*a*c;
        double e = Math.Sqrt(d);
        double root1 = (-b+e) / 2*a;
        double root2 = (-b-e) / 2*a;
        Console.WriteLine("Roots are "+ root1 + " and " + root2);
    }
    
    #endregion

    #region Admission Eligibility
    public void CheckAdmissionEligibility()
    {
        int phy;
        Console.Write("Enter physics mark: ");
        while(!int.TryParse(Console.ReadLine(), out phy))
        {
            Console.Write("Invalid input. Enter physics mark");
        }

        int math;
        Console.Write("Enter math mark: ");
        while(!int.TryParse(Console.ReadLine(), out math))
        {
            Console.Write("Invalid input. Enter math mark");
        }

        int chem;
        Console.Write("Enter chem mark: ");
        while(!int.TryParse(Console.ReadLine(), out chem))
        {
            Console.Write("Invalid input. Enter chem mark");
        }

        if(phy+math+chem>=180 || math + phy >= 140)
        {
            Console.WriteLine("Admission is Approved.");
        }
        else
        {
            Console.WriteLine("Admission is Rejected.");
        }

    }
    
    #endregion

    #region Electricity Bill
    public void CheckElectricityBill(){
        int units;
        Console.WriteLine("Enter total Units: ");
        while (!int.TryParse(Console.ReadLine(), out units)){
            Console.WriteLine("Invalid. Enter total Units: ");
        }
        double result;
        if (units <= 199)
        {
            result= units*1.20;
        }
        else if(200<=units && units<400)
        {
            result = units*1.50;
        }
        else if(400<=units && units < 600)
        {
            result = units*1.80;
        }
        else
        {
            result= units*2.00;
            result = 0.15*result;
        }

        
    }
    #endregion

    #region Vowel or Consonant
    public void checkVowelOrConsonant()
    {
        Console.WriteLine("Enter a character: ");
        string? inp= Console.ReadLine();

        if(char.TryParse(inp, out char ch))
        {
            switch (char.ToLower(ch))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonant");
                    break;
            }
        }
    }
    #endregion

    #region Triangle Type
    public void TriangleType()
    {
        int a, b, c;
        Console.WriteLine("Enter one side a: ");
        while(!int.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Invalid input. Please enter a whole number.");
        }
        
        Console.WriteLine("Enter second side b: ");
        while(!int.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Invalid input. Please enter a whole number.");
        }

        Console.WriteLine("Enter third side c: ");
        while(!int.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("Invalid input. Please enter a whole number.");
        }

        if(a==b && b==c )
        {
            Console.WriteLine("Equilateral Triangle");
        }
        else if(a==b || b==c || a==c)
        {
            Console.WriteLine("Isoceles Triangle");
        }
        else
        {
            Console.WriteLine("Scalene Triangle");
        }

    }
    #endregion

    #region Quadrant Finder
    
    #endregion

    #region Grade Description
    
    #endregion

    #region Valid Date Check
    
    #endregion

    #region ATM Withdrawal
    
    #endregion

    #region Profit/Loss
    
    #endregion
    

}