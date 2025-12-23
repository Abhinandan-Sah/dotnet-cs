using day5.EmployeeAbstract;
using day5.payment;
namespace day5
{
    class Program
    {
        static void Main()
        {
            #region Employee.cs
            // Console.WriteLine("Enter Salary");
            // double salary = double.Parse(Console.ReadLine());
            // IndianEmployee indianEmployee = new IndianEmployee();
            // double taxAmount =indianEmployee.CalTax(salary);
            // double newSalary = salary - taxAmount;
            // Console.WriteLine("Salary after tax deduction: "+newSalary);
            // Console.WriteLine("Tax amount: "+taxAmount);
            #endregion          

            #region Payment.cs
            Payment payment = new UpiPayment(499.00m, "user@upi");
            payment.printReceipt();
            payment.pay();
            #endregion
        }
    }
}
