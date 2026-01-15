namespace day13_Question_M1
{
    public class Program
    {
        public static void Main()
        {
            #region Question 1 - Find Items with sold count, Min and Max sold items, Sort items by sold count
            /// <summary>
            /// Question No-1
            /// </summary>
            
            FindItems.itemDetails.Add("Tea", 5);
            FindItems.itemDetails.Add("Rice", 2);
            FindItems.itemDetails.Add("Bean", 1);
            FindItems.itemDetails.Add("Honey", 7);
            FindItems findItem = new FindItems();
            var data = findItem.FindItemDetails(5);
            foreach(var item in data)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            var minMaxItems = findItem.FindMinAndMaxSoldItems();
            foreach(var item in minMaxItems)
            {
                Console.WriteLine(item);
            }
            var sortedItems = findItem.SortByCount();
            foreach(var item in sortedItems)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            #endregion

            

        }
    }
}