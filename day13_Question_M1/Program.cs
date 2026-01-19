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
            
            // FindItems.itemDetails.Add("Tea", 5);
            // FindItems.itemDetails.Add("Rice", 2);
            // FindItems.itemDetails.Add("Bean", 1);
            // FindItems.itemDetails.Add("Honey", 7);
            // FindItems findItem = new FindItems();
            // var data = findItem.FindItemDetails(5);
            // foreach(var item in data)
            // {
            //     Console.WriteLine($"{item.Key} : {item.Value}");
            // }
            // var minMaxItems = findItem.FindMinAndMaxSoldItems();
            // foreach(var item in minMaxItems)
            // {
            //     Console.WriteLine(item);
            // }
            // var sortedItems = findItem.SortByCount();
            // foreach(var item in sortedItems)
            // {
            //     Console.WriteLine($"{item.Key} : {item.Value}");
            // }
            #endregion

            #region Question 2 - Movie Details - Add Movie, View Movies by Genre, View Movies by Ratings
            /// <summary>
            /// Question No-2
            /// </summary>
            // MovieStock movieStock = new MovieStock();
            // movieStock.AddMovie("Inception,Christopher Nolan,Sci-Fi,9");
            // movieStock.AddMovie("The Dark Knight,Christopher Nolan,Action,10");
            // movieStock.AddMovie("Interstellar,Christopher Nolan,Sci-Fi,8");
            // var sciFiMovies = movieStock.ViewMoviesByGenre("Sci-Fi");
            // foreach(var movie in sciFiMovies)
            // {
            //     Console.WriteLine($"{movie.Title} by {movie.Artist} - Genre: {movie.Genre}, Ratings: {movie.Ratings}");
            // }
            // var moviesByRatings = movieStock.ViewMoviesByRatings();
            // foreach(var movie in moviesByRatings)
            // {
            //     Console.WriteLine($"{movie.Title} by {movie.Artist} - Genre: {movie.Genre}, Ratings: {movie.Ratings}");
            // }
            #endregion

            #region Question 3

            var calculateNumbers = new CalculateNumbers();
            calculateNumbers.AddNumbers(98);
            calculateNumbers.AddNumbers(45);
            calculateNumbers.AddNumbers(72);
            double scored = calculateNumbers.GetGPAScored();
            if (scored == -1)
            {
                
            Console.WriteLine("No Numbers Available");
            }else{
            Console.WriteLine("Total Scored = "+scored);
            }
            char gpa = calculateNumbers.GetGradeScored(scored);
            if (gpa.Equals('I'))
            {
                
            Console.WriteLine("Invalid Grade");
            
            }else{
            Console.WriteLine("GPA = "+gpa);
            }
            
            #endregion


        }
    }
}