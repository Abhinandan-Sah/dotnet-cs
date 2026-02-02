using System.Collections.Generic;
namespace M1_Practice
{
    public class BikeUtility
    {
        public static SortedDictionary<int, Bike> bikeDetails
            = new SortedDictionary<int, Bike>();

        public void AddBikeDetails(string model, string brand, int pricePerDay)
        {
            int key = bikeDetails.Count + 1;

            Bike bike = new Bike
            {
                Model = model,
                Brand = brand,
                PricePerDay = pricePerDay
            };

            bikeDetails.Add(key, bike);
        }

        public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
        {
            SortedDictionary<string, List<Bike>> groupedBikes =
                new SortedDictionary<string, List<Bike>>();

            foreach (var entry in bikeDetails)
            {
                Bike bike = entry.Value;

                if (!groupedBikes.ContainsKey(bike.Brand))
                {
                    groupedBikes[bike.Brand] = new List<Bike>();
                }

                groupedBikes[bike.Brand].Add(bike);
            }

            return groupedBikes;
        }
    }
}