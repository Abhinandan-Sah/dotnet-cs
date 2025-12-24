using day6.InterfaceExample;

namespace day6_Interface_others
{
    public class Program
    {
        public static void Main()
        {
            IPrint iprint = new Document("Maze Runner");
            iprint.print();
        }
    }
}