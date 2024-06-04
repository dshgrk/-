using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ЗнижкоСвіт
{
    public partial class Favorite : Form
    {
        private FavoriteManager favoriteCardManager;
        private FavoriteCardUI favoriteCardUIManager;

        public Favorite()
        {
            InitializeComponent();

            LanguageManager.LanguageChanged += UpdateLanguage;
            UpdateLanguage(this, EventArgs.Empty);

            if (UserManager.CurrentUser is SignInUser user)
            {
                favoriteCardManager = new FavoriteManager(user);
                favoriteCardUIManager = new FavoriteCardUI(tablePanelFavorites, favoriteCardManager);
            }

            ThemeManager.ThemeChanged += UpdateTheme;
            UpdateTheme(this, EventArgs.Empty);
        }

        private void UpdateTheme(object sender, EventArgs e)
        {
            switch (ThemeManager.CurrentTheme)
            {
                case 0:
                    panelCenter.BackColor = Color.LavenderBlush;
                    panelMenu.BackColor = Color.FromArgb(253, 211, 228);
                    panelTop.BackColor = Color.FromArgb(212, 150, 146);

                    break;

                case 1:
                    panelCenter.BackColor = ColorTranslator.FromHtml("#002018");
                    panelMenu.BackColor = ColorTranslator.FromHtml("#543310");
                    panelTop.BackColor = ColorTranslator.FromHtml("#74512D");

                    break;
            }

        }

        private void UpdateLanguage(object sender, EventArgs e)
        {
            switch (LanguageManager.CurrentLanguage)
            {
                case "Українська":
                    buttonHome.Text = "Головна";
                    buttonFav.Text = "Улюблене";
                    buttonSettings.Text = "Налаштування";

                    break;

                case "English":
                    buttonHome.Text = "Home";
                    buttonFav.Text = "Favorites";
                    buttonSettings.Text = "Settings";

                    break;
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void buttonHome_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Hide();
            AppSettings appSettings = new AppSettings();
            appSettings.ShowDialog();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.ShowDialog();
        }

        

    }
}
