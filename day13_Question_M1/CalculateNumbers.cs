namespace day13_Question_M1
{
    public class CalculateNumbers
    {
        public static List<int> NumberList = new List<int>();

        public void AddNumbers(int Numbers)
        {
            NumberList.Add(Numbers);
        }

        public double GetGPAScored()
        {
            int n = NumberList.Count;
            if(n==0) return -1;
            double sum =0;
            foreach(var num in NumberList)
            {
                sum+=(num/10)*3;
            }
            double res = sum/(n*3);
            return res;

        }

        public char GetGradeScored(double gpa)
        {
            if(gpa<5 || gpa>10) return 'I';
            else if(gpa>=5 && gpa<6) return 'D';
            else if(gpa>=6 && gpa<7) return 'C';
            else if(gpa>=7 && gpa<8) return 'B';
            else if(gpa>=8 && gpa<9) return 'A';
            else return 'S';
        }

    }
}