using day6.InterfaceExample;
using day6.ExamManagement;
using MultipleInheritanceInterface;

namespace day6_Interface_others
{
    public class Program
    {
        public static void Main()
        {
            #region Interface.cs
            // IPrint iprint = new Document("Maze Runner");
            // iprint.print();
            #endregion

            #region ExamAssignment.cs, HOD.cs, Invigilator.cs, Exam.cs
            // var hod = new HOD(1, "Dr. Smith");
            // hod.display();
            // var invigilator = new Invigilator(101, "Mr. Johnson");
            // var exam = new Exam(1001, "Mathematics",hod.hodId, "Room 101", new DateTime(2024, 12, 15), new TimeSpan(2, 0, 0));
            // var examAssignment = new ExamAssignment(hod.hodId, exam.examId, invigilator.invigilatorId);
            // Console.WriteLine($"Exam: {exam.subject}, Date: {exam.examDate.ToShortDateString()}, Time: {exam.time.TotalHours} hours, Assigned Invigilator ID: {examAssignment.invigilatorId}");
            #endregion

            #region Multiple Inheritance Using Interface.cs
            VegEater vg = new VegEater();
            vg.vegEater();

            NonVegEater nv = new NonVegEater();
            nv.nonvegEater();

            Visitor v = new Visitor();
            v.vegEater();
            v.nonvegEater();
            v.visitor();
            #endregion

        }
    }
}