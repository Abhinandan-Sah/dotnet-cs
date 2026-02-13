using System.Data.Common;

namespace day12_Linq
{
    public class LinqExample
    {
        public string Name { get; set; }

        public static void LinqStudent()
        {
            string[] names = { "A", "B", "C", "D" };

            // foreach (var item in names)
            // {
            //     if (item == "A")
            //     {
            //         Console.WriteLine("A is Present");
            //     }
            // }

            // var findNames = from nam in names
            //                 where nam == "A"
            //                 select nam;

            // var convert = from nam in names
            //               select nam.ToLower();

            // string[] subs = {"madam", "DAD", "Bro"};
            // var PalindromeName = from nam in subs
            //                         orderby nam descending
            //                         select IsPalindrome(nam.ToLower()); // custom function

            // foreach(var nam in PalindromeName)
            // {
            //     Console.WriteLine($"{nam}");
            // }

            // var findNames  = from nam in names
            //                  orderby nam ascending
            //                  select new LinqExample(){Name =nam};

            // foreach (var nam in findNames)
            // {
            //     Console.WriteLine($"{nam.Name}");
            // }



        }

        public static string IsPalindrome(string name)
        {
            string reversedName = new string(name.Reverse().ToArray());
            if(reversedName.Equals(name))
            {
                return "PALINDROME " + name;
            }
            return "Not a Palindrome "+name;
        }

        public static void LinqExample2(){
            var proCollection = from p in System.Diagnostics.Process.GetProcesses()
                                select new MyProcess() {Name = p.ProcessName, Id=p.Id};
            
            foreach(var proc in proCollection){
                System.Console.WriteLine($"Process Name = {proc.Name} Id = {proc.Id}");
            }
        }
        public static void LinqExample3(){
            var proCollection = from p in System.Diagnostics.Process.GetProcesses()
                                select new {Name = p.ProcessName, Id=p.Id}; // this is called ananymous datatype which scope is within the curly brases
            
            foreach(var proc in proCollection){
                System.Console.WriteLine($"Process Name = {proc.Name} Id = {proc.Id}");
            }
        }

        private class MyProcess{
            public string Name {get; set;}
            public int Id {get; set;}
        }
            select dept, count(emplo), average(salary) from employee groupby dept;
        

    }
}