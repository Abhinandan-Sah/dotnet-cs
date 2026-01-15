namespace day10_Serialization_Delegate
{
    public delegate void myDelegate(string msg);
    public class MultiCastDelegate
    {
        public static void Method1(string msg) => Console.WriteLine("A: "+msg);
        public static void Method2(string msg) => Console.WriteLine("B: "+msg);
        public static void Method3(string msg) => Console.WriteLine("C: "+msg);
    }
}