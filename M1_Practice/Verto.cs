using System.Collections.Generic;
using System.Linq;
// Action Predicate Function
namespace M1_Practice
{

    public class Verto
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int MathMarks { get; set; }
        public int ScienceMarks { get; set; }
        public int TotalMark { get; set; }
        public int Rank { get; set; }

        // Delegate Decleration
        public delegate void RankCalculationHandler(string message);

        //Delegate variable
        public static RankCalculationHandler? RankNotification;

        public Verto(int studentId, string studentName, int mathMarks, int scienceMarks)
        {
            StudentId = studentId;
            StudentName = studentName;
            MathMarks = mathMarks;
            ScienceMarks = scienceMarks;
        }

        public static List<Verto> CalculateRank(List<Verto> students)
        {
            Func<Verto, int> CalculateTotal = (s)=> s.MathMarks+s.ScienceMarks;

            Predicate<Verto> IsPass = (s)=>CalculateTotal(s)>=100;

            Action<Verto> Notify = s => Console.WriteLine($"{s.StudentName} is Passed: {IsPass(s)}");

            foreach (var student in students)
            {
                student.TotalMark = CalculateTotal(student);
                Notify(student);
            }

            var ranked = students
                .OrderByDescending(s => s.TotalMark)
                .ToList();  

            for (int i = 0; i < ranked.Count; i++)
            {
                ranked[i].Rank = i + 1;
            }

            // Notify Rank for Delegate
            RankNotification?.Invoke("Rank has been successfully Calculated.");
            return ranked;

        }
    }
}
