namespace day10_Serialization_Delegate
{
    public delegate string PrintMessage(string message);

    public class PrintingCompany
    {
        public PrintMessage? CustomerChoicePrintMessage{get; set;}

        public void Print(string message)
        {
            string msgToPrint = CustomerChoicePrintMessage(message);
            Console.WriteLine(msgToPrint);
        }
    }
}