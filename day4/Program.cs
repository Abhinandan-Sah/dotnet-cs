using System.Linq.Expressions;
using day4.ConstructorEx;
using day4.ConsAdd;
using day4.fieldInOop;
using day4.Encapulation;
using day4.OverwriteInCS;
using day4.ExampleOnOverwriteAndVirtual;

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
                // var account = new Account(){AccountId=22, name="Avi"};
                // var result = account.getAccountDetails();
                // Console.WriteLine(result);

                // var saleInfo = new SaleInfo(){AccountId=4, name="Ravi", saleInfo= ""};
                // string result1 = saleInfo.getSaleInfoDetails();
                // Console.WriteLine(result1);
                #endregion
                
                #region Account.cs
                // var father = new Father();
                // string? result = father.InterestOn();
                // Console.WriteLine(result);
                // var son = new Son();
                // string? result1 = son.InterestOn();
                // Console.WriteLine(result1);

                Holiday holiday = new Holiday();
                holiday.getHoliday();
                India india = new India();
                india.getHoliday();
                US us = new US();
                us.getHoliday();
                #endregion
                
            }
            catch (Exception err)
            {
                Console.WriteLine("Error : "+err.Message);
            }


            
        }
    }
}