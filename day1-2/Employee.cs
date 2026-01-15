using System;


public class Employee
{
    public string? name;
    public int score;
    public int rank;

    public Employee(string name, int score)
    {
        this.name = name;
        this.score = score;
    }

    public void display()
    {
        Console.WriteLine(name+" "+rank);
    }


}