namespace MediumScenarioBased
{
    public class Employee
    {
        public int Id{get; set;}
        public string Name{get; set;}
        public string Email{get; set;}
        public decimal Salary{get; set;}

        public Employee(int id, string name, string email, decimal salary)
        {
            Id = id; 
            Name = name;
            if (salary <= 0)
            {
                Salary = 30000;
            }
            else
            {
                Salary= salary;
            }

            if (email.Contains('@'))
            {
                Email = email;
            }
            else
            {
                Email = "unknown@company.com";
            }

            
        }

        public void Display()
        {
            System.Console.WriteLine($"{Id} {Name} {Email} {Salary}");
        }

    }

    public class BankAccount
    {
        private double balance;

        public void Deposit(double amount)
        {
            if(amount>0)
                balance+=amount;
        }

        public void WithDraw(double amount)
        {
            if(amount>0 && balance >= amount)
            {
                balance-=amount;
            }
        }

        public void GetBalance()
        {
            System.Console.WriteLine(balance);
        }
    }
  
    public class Cab
    {
        public virtual void CalculateFare(int km)
        {
            System.Console.WriteLine("Base Fare");
        }
    }

    public class Mini : Cab
    {
        public override void CalculateFare(int km)
        {
            System.Console.WriteLine("Fare: "+km*12);
        }
    }
    public class Sedan : Cab
    {
        public override void CalculateFare(int km)
        {
            System.Console.WriteLine(km*15+50);
        }
    }
    public class SUV : Cab
    {
        public override void CalculateFare(int km)
        {
            System.Console.WriteLine(km*18+100);
        }
    }
    public class Program
    {
        public static void Main()
        {
            /*
            // Question 1
            var employee1 = new Employee(1, "Avi", "avi@gmail.com", 200000);
            var employee2 = new Employee(2, "Ankit", "ankgmail.com", 40000);
            var employee3 = new Employee(3, "Avinash", "avinash@gmail.com", -1);
            
            employee1.Display();
            employee2.Display();
            employee3.Display();

            // Question 2
            var bankAccount = new BankAccount();
            bankAccount.Deposit(5000);
            bankAccount.GetBalance();
            bankAccount.WithDraw(200);
            bankAccount.GetBalance();
            bankAccount.Deposit(-600);
            bankAccount.GetBalance();
            bankAccount.WithDraw(10000);
            bankAccount.GetBalance();

            // Question 3
            Console.WriteLine("Enter km: ");
            int km;
            while(!int.TryParse(Console.ReadLine(), out km))
            {
                Console.WriteLine("Invalid Input");
            }

            Console.WriteLine("Enter cab type (mini/sedan/suv): ");
            string type = Console.ReadLine().ToLower();

            Cab cab;

            if(type == "mini")
            {
                cab = new Mini();
            }
            else if(type == "sedan")
            {
                cab = new Sedan();
            }
            else if(type == "suv")
            {
                cab = new SUV();
            }
            else
            {
                System.Console.WriteLine("Invalid type");
                return;
            }

            cab.CalculateFare(km);
            */

            var employee1 = new Employee(1, "Avi", "avi@gmail.com", 200000);
            Type type1 = typeof(Employee);
            Type runtimeType = type1.GetType();
            Type t2 = employee1.GetType();
            System.Console.WriteLine(type1);
            System.Console.WriteLine(runtimeType);
            System.Console.WriteLine(type1.FindMembers);
            System.Console.WriteLine(t2);
            System.Console.WriteLine(type1==t2);

            

        }


        public static string ConvertToPigLatin(string sentence)
        {
            
        }

    }
}