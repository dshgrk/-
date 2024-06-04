using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЗнижкоСвіт
{
    public static class ThemeManager
    {
        public delegate void ThemeChangedHandler(object sender, EventArgs e);
        public static event ThemeChangedHandler ThemeChanged;

        private static int currentTheme = 0;

        public static int CurrentTheme
        {
            get => currentTheme;
            set
            {
                if (currentTheme != value)
                {
                    currentTheme = value;
                    OnThemeChanged();
                }
            }
        }

        private static void OnThemeChanged()
        {
            ThemeChanged?.Invoke(null, EventArgs.Empty);
        }
    }
}