namespace day6.ExamManagement{
    public class Exam
    {
        public int examId{get; set;}
        public string subject{get;}
        public int hodId {get;}
        public string location{get;}
        public DateTime examDate{get;}
        public TimeSpan time{get;}

        public Exam(int examId, string subject, int hodId, string location, DateTime examDate, TimeSpan time)
        {
            this.examId = examId;
            this.subject = subject;
            this.hodId = hodId;
            this.location = location;
            this.examDate = examDate;
            this.time = time;
        }
    }
}