namespace Movies.System;

public static class MovieExtensions
{
    public static bool IsNewRelease(this Movie m)
    {
        return m.Year > 2021;
    }

    public static string ToShortInfo(this Movie m) => $"{m.Title} - {m.Year}";
    
}