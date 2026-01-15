namespace day6.InterfaceExample
{
    public interface IPrint
    {
        void print();
    }

    public class Document: IPrint
    {
        public string Title{get; set;}
        public Document(string title)
        {
            Title = title;
        }

        public void print()
        {
            Console.WriteLine($"Document Title: {Title}");
        }
    }
}