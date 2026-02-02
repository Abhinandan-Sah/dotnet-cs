namespace M1_Practice
{
    public class Program
    {
        public static void ShowNotification(string message)
        {
            Console.WriteLine($"Notification: {message}");
        }

        public static SortedDictionary<int, Bike> bikeDetails = BikeUtility.bikeDetails;
        public static void Main(string[] args)
        {
            // WordWand.cs
            // WordWand.WordWandAnswer();

            // Verto.RankNotification = ShowNotification;

            // // GenericsPractice1.cs
            // List<Verto> student1 = new List<Verto>{new Verto(1, "Avi", 10, 50),
            // new Verto(2, "Vikash", 60, 50)};

            // List<Verto> students = Verto.CalculateRank(student1);

            // foreach(var s in students)
            // {
            //     Console.WriteLine($"The rank of {s.StudentName} rank {s.Rank}");

            // }









            BikeUtility utility = new BikeUtility();

            while (true)
            {
                Console.WriteLine("1. Add Bike Details");
                Console.WriteLine("2. Group Bikes By Brand");
                Console.WriteLine("3. Exit");
                Console.WriteLine();
                Console.WriteLine("Enter your choice");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the model");
                        string model = Console.ReadLine();

                        Console.WriteLine("Enter the brand");
                        string brand = Console.ReadLine();

                        Console.WriteLine("Enter the price per day");
                        int price = int.Parse(Console.ReadLine());

                        utility.AddBikeDetails(model, brand, price);
                        Console.WriteLine("Bike details added successfully");
                        Console.WriteLine();
                        break;

                    case 2:
                        SortedDictionary<string, List<Bike>> grouped =
                            utility.GroupBikesByBrand();

                        foreach (var brandEntry in grouped)
                        {
                            Console.WriteLine(brandEntry.Key);
                            foreach (Bike bike in brandEntry.Value)
                            {
                                Console.WriteLine(bike.Model);
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        return;
                }
            }






        }
    }
}