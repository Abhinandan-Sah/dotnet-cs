using System.Security.Cryptography.X509Certificates;

namespace day5.EmployeeAbstract
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Employee
    {
        public int salary;
        public abstract  double CalTax(int s);
    }
    
    public class IndianEmployee: Employee
    {
        public override double CalTax(int s)
        {
            return s*0.20;
        }
    }
    public class UsEmployee: Employee
    {
        public override double CalTax(int s)
        {
            return s*0.30;
        }
    }
}