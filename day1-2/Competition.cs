public class Competition
{
    public string? name;
    public List<Employee> employees;


    public Competition(string name)
    {
        this.name = name;
        employees= new List<Employee>();
    }

    public void addEmployee(Employee emp) 
    {
        employees.Add(emp);
    }
    


}