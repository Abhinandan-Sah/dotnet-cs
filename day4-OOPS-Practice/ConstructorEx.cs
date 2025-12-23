namespace day4.ConstructorEx
{
    public class Visitor
    {
        public int Id{get; set;}
        public string? Name{get; set;}
        public string? Requirement{get; set;}

        public string? LogHistory {get; set;}

        // it prevent the creating of empty object by calling default construction so we have make the it explicitly and make private
        // private Visitor() 
        // {
            
        // }
        
        public Visitor()
        {
            LogHistory += $"Object created on {DateTime.Now} {Environment.NewLine}";
        }

        public Visitor(int id):this()
        {
            Id= id;
            LogHistory += $"id created on {DateTime.Now} {Environment.NewLine}";
        }
        public Visitor(int id, string name) : this(id)
        {
            if(name.ToLower().Contains("dumb"))
                throw new ArgumentException("You are dumb. Provide proper name");
            if (name.Any(char.IsDigit))
            {
                throw new ArgumentException("Cannot use number in name");
            }
            Name = name;
            LogHistory += $"Name created on {DateTime.Now} {Environment.NewLine}";
        }

        public Visitor(int id, string name, string requirement): this(id, name)
        {
            Requirement = requirement;
            LogHistory += $"Requirement created on {DateTime.Now} {Environment.NewLine}";
        }


    }
}