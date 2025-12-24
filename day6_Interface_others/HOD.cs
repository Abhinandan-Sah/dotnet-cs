namespace day6.ExamManagement{
public class HOD
{
    public int hodId{get;}
    public string Name{get;}

    public HOD(int hodId, string name)
    {
        this.hodId = hodId;    
        Name = name;
    }

    public void display()
    {
        Console.WriteLine($"HOD Name: {Name}");
    }
}
}