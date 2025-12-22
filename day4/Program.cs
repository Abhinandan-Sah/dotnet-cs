using System.Linq.Expressions;
using day4.ConstructorEx;
using day4.ConsAdd;
using day4.fieldInOop;
using day4.Encapulation;

namespace day4
{
    public class Program{
        public static void Main()
        {
            try
            {
                #region ConstructorEx.cs
                // Visitor visitor= new Visitor(1, "Ravi", "Name should be present");
                // Console.WriteLine(visitor.LogHistory);
                #endregion


                #region ConsAdd.cs
                // var objAdd= new Add(2, 4);
                // int res= objAdd.add();
                // Console.WriteLine("sum is "+objAdd.result);
                #endregion

                #region CallField.cs
                // Employee employee = new Employee();
                // employee.Id=4;
                // Console.WriteLine(employee.id);
                // string result = employee.DisplayEmpDetails();
                // Console.WriteLine(result);
                #endregion

                #region EmployeeValidation.cs
                // var employee = new Employee();
                // employee.Id=2;
                #endregion

                #region Account.cs
                var account = new Account(){AccountId=22, name="Avi"};
                var result = account.getAccountDetails();
                Console.WriteLine(result);

                var saleInfo = new SaleInfo(){AccountId=4, name="Ravi", saleInfo= ""};
                string result1 = saleInfo.getSaleInfoDetails();
                Console.WriteLine(result1);
                #endregion
                
            }
            catch (Exception err)
            {
                Console.WriteLine("Error : "+err.Message);
            }


            
        }
    }
}