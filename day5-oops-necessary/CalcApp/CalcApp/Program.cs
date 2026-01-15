namespace MainAPP
{
    using MathLib;
    using ScienceLib;
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOps = new MathOperations();
            ScienceOperations scienceOps = new ScienceOperations();
            int sum = mathOps.Add(5, 10);
            int difference = mathOps.Subtract(10, 5);
            int density = scienceOps.AeroDensity(1000);
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Aero Density at 1000m: {density}");
        }
    }
}