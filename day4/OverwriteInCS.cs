namespace day4.OverwriteInCS
{
    public class Father
    {
        public virtual string InterestOn()
        {
            return "I like to play cricket";
        }
    }

    public class Son: Father
    {
        public override string InterestOn()
        {
            return "Mobile Games";
        }
    }
}