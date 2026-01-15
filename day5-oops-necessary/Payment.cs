namespace day5.payment
{
    public abstract class Payment
    {
        public decimal Amount{get;}
        protected Payment(decimal amount)
        {
            Amount= amount;
        }

        public void printReceipt()
        {
            Console.WriteLine($"Amount pay is {Amount}");
        }

        public abstract void pay();
    }

    public class UpiPayment: Payment{
        public string UpiId;
        public UpiPayment(decimal amount, string upiId): base(amount)
        {
            UpiId=upiId;
        }
        public override void pay(){
            Console.WriteLine($"Paid {Amount} via upi id {UpiId}");
        }
        
    }

}