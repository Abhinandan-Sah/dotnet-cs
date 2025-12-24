namespace MultipleInheritanceInterface
{
    interface IvegEater
    {
        public void vegEater();
    }
    interface INonvegEater
    {
        public void nonvegEater();
    }

    public class VegEater: IvegEater
    {
        public void vegEater()
        {
            Console.WriteLine("I am vegEater class.");
        }
    }

    public class NonVegEater: INonvegEater
    {
        public void nonvegEater()
        {
            Console.WriteLine("I am non-vegEater class");
        }
    }

    public class Visitor: IvegEater, INonvegEater
    {
        public void vegEater()
        {
            Console.WriteLine("I am visitor class with vegEater.");
        }
        public void nonvegEater()
        {
            Console.WriteLine("I am visitor class with non-vegEater.");
        }
        public void visitor()
        {
            Console.WriteLine("I am visitor class with visitor function");
        }
    }
}