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
        
    }

    #endregion

    #region Quadratic Equation
    public void CheckQuadraticEquation()
    {
        
    }
    
    #endregion

    #region Admission Eligibility
    public void CheckAdmissionEligibility()
    {
        
    }
    
    #endregion

    #region Electricity Bill
    
    #endregion

    #region Vowel or Consonant
    
    #endregion

    #region Triangle Type
    
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