namespace L037_Library;

static class StringExtensions
{
    public static int WordCount(this string s)
    {
        return s.Split(' ').Length;
    }

    public static string Encapsulate(this string s, string enclosure)
    {
        return $"{enclosure} {s} {enclosure}";
    }

    public static string Encapsulate(this string s, string enclosureA , string enclosureB)
    {
        return $"{enclosureA} {s} {enclosureB}";
    }
}

