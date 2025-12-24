namespace day6.ExamManagement{
    public class ExamAssignment 
    {
        public int examId{get;}
        public int  invigilatorId{get;}
        public int hodId;
        public ExamAssignment (int hodId, int examId, int invigilatorId)
        {
            this.hodId = hodId;
            this.examId = examId;
            this.invigilatorId = invigilatorId;
        }
    
    }
}