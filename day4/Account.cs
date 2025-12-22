namespace day4.Encapulation
{
    public class Account
    {
        public int AccountId {get; set;}
        public string? name {get; set;}

        public string getAccountDetails()
        {
            return $"I am base class with Account Id: {AccountId}";
        }
    }

    public class SaleInfo: Account
    {
        public string? saleInfo;

        public string getSaleInfoDetails()
        {
            string? info = string.Empty;
            info += base.getAccountDetails();
            info += $"I am sales derived class";
            return info;
        }
    }

    public class PurchaseInfo: SaleInfo
    {
        public string? purchaseInfo;
    }
}