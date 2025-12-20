using System.Security.Cryptography.X509Certificates;

public class Person
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
}

public class Man : Person
{
    public string? Playing { get; set; }
}

public class Women : Person
{
    public string? PlayManage { get; set; }
}

public class Program
{
    public static void Main()
    {
        Program prog = new Program();

        string result = string.Empty;

        Person person = new Person { Id = 1, Name = "Avi", Age = 22 };
        result=prog.getDetails(person);
        Console.WriteLine(result);

        Man m = new Man{Id = 2, Name = "Rohit", Age = 21, Playing= "Football"};
        person=m;
        result=prog.getDetails(m);
        Console.WriteLine(result);

        Women w = new Women{Id = 2, Name = "sansa", Age = 21, PlayManage= "Rugby and Boxing"};
        person=w;
        result=prog.getDetails(w);
        Console.WriteLine(result);


    }

    public string getDetails(Person p)
    {
        string result = string.Empty;
        if(p is Man)
        {
            Man m = (Man) p;
            result = $"id = {p.Id}, name = {p.Name}, Age = {p.Age}, Playing= {m.Playing}";
        }
        if(p is Women)
        {
            Women w = (Women) p;
            result = $"id = {p.Id}, name = {p.Name}, Age = {p.Age}, Playing= {w.PlayManage}";
        }
        result = $"id = {p.Id}, name = {p.Name}, Age = {p.Age}";
        return result;
    }

    // public string getManDetails(Man m)
    // {
    //     return $"id = {m.Id}, name = {m.Name}, Age = {m.Age}, Playing={m.Playing}";
    // }
    // public string getWomenDetails(Women w)
    // {
    //     return $"id = {w.Id}, name = {w.Name}, Age = {w.Age}, PlayManage= {w.PlayManage}";
    // }

}