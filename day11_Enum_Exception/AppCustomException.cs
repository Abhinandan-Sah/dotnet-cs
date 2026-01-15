namespace day11_Enum_Exception
{
    class AppCustomException : Exception
    {
        // public override string Message => "Internal Exception";
        public override string Message => HandleBase(base.Message);

        private string HandleBase(string sysMessage)
        {
            Console.WriteLine(sysMessage);

            return "Custom Exception: Division by zero is not allowed.";
        }
    }
}