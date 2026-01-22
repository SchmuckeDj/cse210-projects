public class Word
{
    // ===== Variables =====
    private string _text;
    private bool _isHidden;

    // ===== Constructor =====
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // ===== Métodos =====
    public void Hide()
    {
       
    }

    public void Show()
    {
        
    }

    public bool IsHidden()
    {
        return false;
    }

    public string GetDisplayText()
    {
        return "";
    }
}
