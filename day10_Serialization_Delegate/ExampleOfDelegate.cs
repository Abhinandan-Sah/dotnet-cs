namespace day10_Serialization_Delegate
{
    public delegate int DelegateAddFunction(int a, int b);
    public class ExampleOfDelegate
    {
        public int a;
        public int b;

        public void DelegateEx1()
        {
            DelegateAddFunction delegateVariable = new DelegateAddFunction(AddMethod);
            Console.WriteLine(delegateVariable.Method);
            int result = delegateVariable(2, 3);
            Console.WriteLine("Result is: " + result);
        }

        public int AddMethod(int a, int b)
        {
            return a + b;
        }
    }
}