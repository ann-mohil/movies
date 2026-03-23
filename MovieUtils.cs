namespace Movies.System;

public static class MovieUtils
{
    public static List<Movie> FilterByRating(List<Movie> movies, double minRating)
    {
        List<Movie> _moviesRated = new List<Movie>();
        foreach (var m in movies)
        {
            if (m.Rating > minRating)
            {
                _moviesRated.Add(m);
            }
        }
        return _moviesRated;
    }

    public static string GetTopDirector(List<Movie> movies)
    {
        if (movies.Count == 0)
        {
            return "Список порожній";
        }
        Dictionary<string, int> counts = new Dictionary<string, int>();
        foreach (var m in movies)
        {
            if (counts.ContainsKey(m.Director))
            {
                counts[m.Director]++;
            }
            else
            {
                counts[m.Director] = 1;
            }
        }

        string topDirector = "";
        int maxCount = 0;
        foreach (var e in counts)
        {
            if (e.Value > maxCount)
            {
                maxCount = e.Value;
                topDirector = e.Key;
            }
        }
        return topDirector;
    }
}