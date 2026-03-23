namespace Movies.System;

class Program
{
    static void Main(string[] args)
    {
        var movie1 = new Movie("F1", "Kosinski", 2025, 10, null);
        var movie2 = new Movie("F1", "Kosinski", 2025, 10, null);
        var movie3 = new Movie("The Nun", "Hardy", 2018, 10, null);
        Console.WriteLine(movie1);
        Console.WriteLine(movie1.Equals(movie2));
        Console.WriteLine(movie1 == movie2);
        var set = new HashSet<Movie> { movie1, movie2, movie3 };
        Console.WriteLine(set.Count);
        Console.WriteLine(Movie.TotalMovies);
        Console.WriteLine(IsbnValidator.IsValid("2556878996532"));
        Console.WriteLine(movie1.Description == null);
        Console.WriteLine(movie1.Description?.Length ?? -1);
        Console.WriteLine(movie1.IsNewRelease());
        Console.WriteLine(movie1.ToShortInfo());
    }
}