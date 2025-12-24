namespace day6.ExamManagement{

public class Invigilator
{
    public int invigilatorId{get;}
    public string Name{get;}

    public Invigilator(int invigilatorId, string name)
    {
        this.invigilatorId = invigilatorId;    
        Name = name;
    }
}
}