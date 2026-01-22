public class Reference
{
    // ===== Variables =====
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // ===== Constructor (un solo versículo) =====
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }

    // ===== Constructor (rango de versículos) =====
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // ===== Métodos =====
    public string GetDisplayText()
    {
        return "";
    }
}
