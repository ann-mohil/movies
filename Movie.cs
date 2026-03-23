namespace Movies.System;

public class Movie
{
    public string Title { get; }
    public string Director { get; }
    public int Year { get; }
    public double Rating { get; }
    public string? Description { get; }

    public Movie(string title, string director, int year, double rating, string description)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
        Description = description;
        _totalMovies++;
    }

    public override string ToString()
    {
        string desc = Description ?? "Опис відсутній";
        return $"{Title} - {Director} - {Year} - {Rating} - {Description}";
    }
    public override bool Equals(object? obj)
    {
        if (obj is not Movie other) return false;
        return Title == other.Title && Director == other.Director && Year == other.Year;
    }

    public override int GetHashCode() => HashCode.Combine(Title, Director, Year);
    private static int _totalMovies = 0;
    public static int TotalMovies => _totalMovies;
    
}
public static class IsbnValidator
{
    public static bool IsValid(string isbn) 
        => isbn.Length == 13 && isbn.All(char.IsDigit);
}