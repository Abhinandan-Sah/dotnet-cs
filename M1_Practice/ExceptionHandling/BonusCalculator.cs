using System;
namespace M1_Practice{
class BonusCalculator
{
    static void Main()
    {
        // TODO:
        // 1. Loop through salaries
        // 2. Divide bonus by salary
        // 3. Handle DivideByZeroException
        // 4. Continue processing remaining employees
        int[] salaries = { 5000, 0, 7000 };

        int bonus=10000;

            try
            {
                foreach(var salary in salaries){
                    int result = bonus/salary;
                    Console.WriteLine("Bonus: "+result);
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Salary is zero. Cannot calculate bonus.");
            }

    }
}
}