namespace EmployeeApp.Tests;

public interface IStudent
{
    public int studentId { get; set; }
    public string studentName { get; set; }

    public string GetStudentDetails();
}

public class Student : IStudent
{
    public int studentId { get; set; }
    public string studentName { get; set; }

    public string GetStudentDetails()
    {
        return $"ID: {studentId}, Name: {studentName}";
    }
}

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
}
