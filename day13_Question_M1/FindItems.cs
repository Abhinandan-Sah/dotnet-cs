namespace day13_Question_M1
{
    public class FindItems
    {
        public static SortedDictionary<string, long> itemDetails = new SortedDictionary<string, long>();

        public SortedDictionary<string, long> FindItemDetails(long soldCount)
        {
            SortedDictionary<string, long> ans = new SortedDictionary<string, long>();
            foreach (var item in itemDetails)
            {
                if (soldCount == item.Value)
                {
                    ans.Add(item.Key, item.Value);
                }
            }

            return ans;
        }

        public List<string> FindMinAndMaxSoldItems()
        {
            long mini = 0;
            long maxi = 0;
            List<string> result = new List<string>();
            foreach(var item in itemDetails)
            {
                if (mini > item.Value)
                {
                    mini=item.Value;
                }
                if (maxi < item.Value)
                {
                    maxi = item.Value;
                }
            }

            foreach(var item in itemDetails)
            {
                if(item.Value == mini || item.Value == maxi)
                {
                    result.Add(item.Key);
                }
            }
            return result;
        }

        public Dictionary<string, long> SortByCount()
        {
            var res = from item in itemDetails
                        orderby item.Value ascending
                        select item;

            return res.ToDictionary(x => x.Key, x => x.Value);

            // var itemDetailsSorted = itemDetails.ToList().OrderBy(x=>x.Value);
            // return itemDetailsSorted.ToDictionary(x => x.Key, x => x.Value);
        }

    }
}