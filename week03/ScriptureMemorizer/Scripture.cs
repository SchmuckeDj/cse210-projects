using System;


public class Scripture
{
    // ===== Variables (atributos) =====
    private Reference _reference;
    private List<Word> _words;

    // ===== Constructor =====
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
    }

    // ===== Métodos =====
    public void HideRandomWords(int numberToHide)
    {
        
    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}
