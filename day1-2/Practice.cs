using System;
using System.Runtime.CompilerServices;

namespace dotnet;

public class Practice
{
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

        if (int.TryParse(input, out int h))
        {
            if (h < 150) Console.WriteLine("Dwarf");
            if (h >= 150 && h < 165) Console.WriteLine("Average");
            if (h >= 165 && h <= 190) Console.WriteLine("Tall");
            if (h > 190) Console.WriteLine("Abnormal");
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
        string? i1 = Console.ReadLine();

        Console.WriteLine("Enter 2nd no: ");
        string? i2 = Console.ReadLine();

        Console.WriteLine("Enter 3th no: ");
        string? i3 = Console.ReadLine();

        if (int.TryParse(i1, out int n1) && int.TryParse(i2, out int n2) && int.TryParse(i3, out int n3))
        {
            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine(n1 + " is Greatest.");
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine(n2 + " is Greatest.");
            }
            else
            {
                Console.WriteLine(n3 + " is Greatest.");
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
        string? inp = Console.ReadLine();

        if (int.TryParse(inp, out int year))
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
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

        while (!int.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Invalid input. Please enter a number:");
        }

        int b;

        Console.WriteLine("Enter b: ");

        while (!int.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Invalid input. Please enter a number:");
        }

        int c;

        Console.WriteLine("Enter c: ");

        while (!int.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("Invalid input. Please enter a number:");
        }

        double d = b * b - 4 * a * c;
        double e = Math.Sqrt(d);
        double root1 = (-b + e) / 2 * a;
        double root2 = (-b - e) / 2 * a;
        Console.WriteLine("Roots are " + root1 + " and " + root2);
    }

    #endregion

    #region Admission Eligibility
    public void CheckAdmissionEligibility()
    {
        int phy;
        Console.Write("Enter physics mark: ");
        while (!int.TryParse(Console.ReadLine(), out phy))
        {
            Console.Write("Invalid input. Enter physics mark");
        }

        int math;
        Console.Write("Enter math mark: ");
        while (!int.TryParse(Console.ReadLine(), out math))
        {
            Console.Write("Invalid input. Enter math mark");
        }

        int chem;
        Console.Write("Enter chem mark: ");
        while (!int.TryParse(Console.ReadLine(), out chem))
        {
            Console.Write("Invalid input. Enter chem mark");
        }

        if (phy + math + chem >= 180 || math + phy >= 140)
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
    public void CheckElectricityBill()
    {
        int units;
        Console.WriteLine("Enter total Units: ");
        while (!int.TryParse(Console.ReadLine(), out units))
        {
            Console.WriteLine("Invalid. Enter total Units: ");
        }
        double result;
        if (units <= 199)
        {
            result = units * 1.20;
        }
        else if (200 <= units && units < 400)
        {
            result = units * 1.50;
        }
        else if (400 <= units && units < 600)
        {
            result = units * 1.80;
        }
        else
        {
            result = units * 2.00;
            result = 0.15 * result;
        }

    }
    #endregion

    #region Vowel or Consonant
    public void CheckVowelConsonent()
    {
        string? inp=Console.ReadLine();
        if (string.IsNullOrEmpty(inp))
        {
            Console.WriteLine("Invalid Input");
            return;
        }
        char ch = char.ToLower(inp[0]);
        switch(ch){
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("Vowel");
                break;
            default:
                Console.WriteLine("Consonent");
                break;
        }
    }
    #endregion

    #region Triangle Type

    #endregion

    #region Quadrant Finder
    public void QuadrantFinder()
    {
        int x, y;

        Console.Write("Enter X coordinate: ");
        while (!int.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Invalid input. Enter an integer for X:");
        }

        Console.Write("Enter Y coordinate: ");
        while (!int.TryParse(Console.ReadLine(), out y))
        {
            Console.WriteLine("Invalid input. Enter an integer for Y:");
        }

        if (x > 0 && y > 0)
        {
            Console.WriteLine($"The point ({x}, {y}) lies in the First Quadrant.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine($"The point ({x}, {y}) lies in the Second Quadrant.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine($"The point ({x}, {y}) lies in the Third Quadrant.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine($"The point ({x}, {y}) lies in the Fourth Quadrant.");
        }
        else if (x == 0 && y == 0)
        {
            Console.WriteLine("The point is at the Origin.");
        }
        else
        {
            Console.WriteLine("The point lies on an Axis.");
        }
    }
    #endregion

    #region Grade Description
    public void GradeDescription()
    {
        String? inp = Console.ReadLine();
        if (string.IsNullOrEmpty(inp))
        {
            Console.WriteLine("Invalid Input");
            return;
        }
        char ch = char.ToLower(inp[0]);
        switch (ch)
        {
            case 'E':
                Console.WriteLine("Excellient");
                break;
            case 'V':
                Console.WriteLine("Very Good");
                break;
            case 'G':
                Console.WriteLine("Good");
                break;
            case 'F':
                Console.WriteLine("Fail");
                break;
            default:
                Console.WriteLine("Out of Range");
                break;
        }
        
    }
    #endregion

    #region Valid Date Check
    public void ValidateDate()
    {
        int day, month, year;

        Console.Write("Enter day: ");
        while (!int.TryParse(Console.ReadLine(), out day))
        {
            Console.Write("Invalid input. Enter day: ");
        }

        Console.Write("Enter month: ");
        while (!int.TryParse(Console.ReadLine(), out month))
        {
            Console.Write("Invalid input. Enter month: ");
        }

        Console.Write("Enter year: ");
        while (!int.TryParse(Console.ReadLine(), out year))
        {
            Console.Write("Invalid input. Enter year: ");
        }

        bool isValid = true;

        if (month < 1 || month > 12)
        {
            isValid = false;
        }
        else if (day < 1)
        {
            isValid = false;
        }
        else
        {
            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            
            // Check for leap year
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                daysInMonth[1] = 29;
            }

            if (day > daysInMonth[month - 1])
            {
                isValid = false;
            }
        }

        if (isValid)
        {
            Console.WriteLine($"{day}/{month}/{year} is a valid date.");
        }
        else
        {
            Console.WriteLine($"{day}/{month}/{year} is not a valid date.");
        }
    }
    #endregion

    #region ATM Withdrawal
    public void ATMWithdrawal()
    {
        int balance, amount;

        Console.Write("Enter account balance: ");
        while (!int.TryParse(Console.ReadLine(), out balance) || balance < 0)
        {
            Console.Write("Invalid input. Enter account balance: ");
        }

        Console.Write("Enter withdrawal amount: ");
        while (!int.TryParse(Console.ReadLine(), out amount) || amount < 0)
        {
            Console.Write("Invalid input. Enter withdrawal amount: ");
        }

        if (amount % 100 != 0)
        {
            Console.WriteLine("Amount must be in multiples of 100.");
        }
        else if (amount > balance)
        {
            Console.WriteLine("Insufficient balance.");
        }
        else if (amount > 20000)
        {
            Console.WriteLine("Daily withdrawal limit is 20,000.");
        }
        else
        {
            int remainingBalance = balance - amount;
            Console.WriteLine($"Withdrawal successful. Remaining balance: {remainingBalance}");
        }
    }
    #endregion

    #region Profit/Loss
    public void CheckProfitLoss()
    {
        double costPrice, sellingPrice;

        Console.Write("Enter cost price: ");
        while (!double.TryParse(Console.ReadLine(), out costPrice) || costPrice < 0)
        {
            Console.Write("Invalid input. Enter cost price: ");
        }

        Console.Write("Enter selling price: ");
        while (!double.TryParse(Console.ReadLine(), out sellingPrice) || sellingPrice < 0)
        {
            Console.Write("Invalid input. Enter selling price: ");
        }

        if (sellingPrice > costPrice)
        {
            double profit = sellingPrice - costPrice;
            double profitPercentage = (profit / costPrice) * 100;
            Console.WriteLine($"Profit: {profit:F2}");
            Console.WriteLine($"Profit Percentage: {profitPercentage:F2}%");
        }
        else if (sellingPrice < costPrice)
        {
            double loss = costPrice - sellingPrice;
            double lossPercentage = (loss / costPrice) * 100;
            Console.WriteLine($"Loss: {loss:F2}");
            Console.WriteLine($"Loss Percentage: {lossPercentage:F2}%");
        }
        else
        {
            Console.WriteLine("No profit, no loss.");
        }
    }
    #endregion



}