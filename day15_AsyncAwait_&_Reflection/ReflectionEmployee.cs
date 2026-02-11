using System;
using System.Reflection;

namespace Reflection_Namespace
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public decimal Salary { get; private set; }

        private string secretCode = "X9Z";

        public Employee() { }

        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void GiveRaise(decimal amount)
        {
            Salary += amount;
        }

        private string GetSecretCode() => secretCode;

        public static void Main()
        {
            // Employee emp = new Employee(101, "Arun", 45000);

            // Type t1 = typeof(Employee);     // compile-time
            // Type t2 = emp.GetType();        // runtime

            // Console.WriteLine(t1.FullName);
            // Console.WriteLine(t2.FullName);
            // Console.WriteLine(t1 == t2);    // True


            Type t = typeof(Employee);

            // var methods = t.GetMethods(); // public instance + inherited public methods

            // foreach (var m in methods)
            // {
            //     Console.WriteLine($"{m.ReturnType.Name} {m.Name}()");
            // }

            // foreach (PropertyInfo p in t.GetProperties())
            // {
            //     Console.WriteLine($"{p.PropertyType.Name} {p.Name} (CanRead={p.CanRead}, CanWrite={p.CanWrite})");
            // }

            // System.Console.WriteLine(t.GetFields());

            foreach (FieldInfo f in t.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Console.WriteLine($"{f.FieldType.Name} {f.Name}");
            }

            
        }
    }
}