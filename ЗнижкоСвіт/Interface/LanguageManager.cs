using System;

public static class LanguageManager
{
    public delegate void LanguageChangedHandler(object sender, EventArgs e);
    public static event LanguageChangedHandler LanguageChanged;

    private static string currentLanguage = "Українська";

    public static string CurrentLanguage
    {
        get => currentLanguage;
        set
        {
            if (currentLanguage != value)
            {
                currentLanguage = value;
                OnLanguageChanged();
            }
        }
    }

    private static void OnLanguageChanged()
    {
        LanguageChanged?.Invoke(null, EventArgs.Empty);
    }
}
