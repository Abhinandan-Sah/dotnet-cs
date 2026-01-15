namespace MultipleInheritanceInterface
{
    interface IvegEater
    {
        public void vegEater();
        public void GetTaste();
    }
    interface INonvegEater
    {
        public void nonvegEater();
        public void GetTaste();
    }

    // public class VegEater: IvegEater
    // {
    //     public void vegEater()
    //     {
    //         Console.WriteLine("I am vegEater class.");
    //     }
    // }

    // public class NonVegEater: INonvegEater
    // {
    //     public void nonvegEater()
    //     {
    //         Console.WriteLine("I am non-vegEater class");
    //     }
    // }

    public class Visitor : IvegEater, INonvegEater
    {
        void IvegEater.vegEater()
        {
            Console.WriteLine("I am visitor class with vegEater.");
        }
        void IvegEater.GetTaste()
        {
            Console.WriteLine("Veg rank 2");
        }
        void INonvegEater.nonvegEater()
        {
            Console.WriteLine("I am visitor class with non-vegEater.");
        }
        void INonvegEater.GetTaste()
        {
            Console.WriteLine("Non-veg rank 1");
        }
        public void visitor()
        {
            Console.WriteLine("I am visitor class with visitor function");
        }
    }
}