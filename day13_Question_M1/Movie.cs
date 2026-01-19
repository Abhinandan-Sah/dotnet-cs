namespace day13_Question_M1
{
    public class Movie
    {
        public string? Title {get; set;}
        public string? Artist{get; set;}
        public string? Genre{get; set;}
        public int Ratings{get; set;}


    }

    public class MovieStock
    {
        public static List<Movie> MovieList = new List<Movie>();

        public void AddMovie(string MovieDetails)
        {
            var details = MovieDetails.Split(',');
            MovieList.Add(new Movie(){Title = details[0], Artist = details[1], Genre = details[2], Ratings =int.Parse(details[3])});
        }

        public List<Movie> ViewMoviesByGenre(string genre)
        {
            List<Movie> ans = new List<Movie>();
            foreach(var movie in MovieList)
            {
                if(movie.Genre == genre)
                {
                    ans.Add(movie);
                }
            }
            return ans;
        }

        public List<Movie> ViewMoviesByRatings()
        {
            var ans = from movie in MovieList
                      orderby movie.Ratings descending
                      select movie;
            return ans.ToList();
        }

    }
}