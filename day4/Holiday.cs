namespace day4.ExampleOnOverwriteAndVirtual
{

    public class Holiday
    {
        public virtual void getHoliday()
        {
            Console.WriteLine("Define your own holiday");
        }
    }
    public class India:Holiday
    {
        public override void getHoliday()
        {
            Console.WriteLine("holi, diwali");
        }
    }
    public class US:Holiday
    {
        public override void getHoliday()
        {
            Console.WriteLine("christmas");
        }
    }
}