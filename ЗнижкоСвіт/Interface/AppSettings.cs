using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЗнижкоСвіт
{
    public partial class AppSettings : Form
    {
        public MainForm mainForm;
        public Favorite favorite;
        public SignIn signIn;

        public AppSettings()
        {
            InitializeComponent();

            favorite = new Favorite();
            mainForm = new MainForm();
            signIn = new SignIn();

            this.Load += AppSettings_Load;
            comboBoxTheme.SelectedIndex = ThemeManager.CurrentTheme;

            signIn.UserLoggedIn += SignIn_UserLoggedIn;

            LanguageManager.LanguageChanged += UpdateLanguage;
            UpdateLanguage(this, EventArgs.Empty);

            ThemeManager.ThemeChanged += UpdateTheme;
            UpdateTheme(this, EventArgs.Empty);
        }

        private void SignIn_UserLoggedIn(string userName)
        {
            textBoxUsername.Text = userName;
        }

        private void UpdateLanguage(object sender, EventArgs e)
        {
            switch (LanguageManager.CurrentLanguage)
            {
                case "Українська":
                    buttonHome.Text = "Головна";
                    buttonFav.Text = "Улюблене";
                    buttonSettings.Text = "Налаштування";

                    labelAccSett.Text = "Налаштування акаунту";
                    labelNickname.Text = "Нікнейм";
                    labelSettingsInterface.Text = "Налаштування інтерфейсу";
                    labelLanguage.Text = "Мова";
                    labelTheme.Text = "Тема";

                    comboBoxTheme.Items[0] = "Світла";
                    comboBoxTheme.Items[1] = "Темна";

                    break;

                case "English":
                    buttonHome.Text = "Home";
                    buttonFav.Text = "Favorites";
                    buttonSettings.Text = "Settings";

                    labelAccSett.Text = "Account settings";
                    labelNickname.Text = "Nickname";
                    labelSettingsInterface.Text = "Interface settings";
                    labelLanguage.Text = "Lang";
                    labelTheme.Text = "Theme";

                    comboBoxTheme.Items[0] = "Light";
                    comboBoxTheme.Items[1] = "Dark";

                    break;
            }
        }

        private void AppSettings_Load(object sender, EventArgs e)
        {
            comboBoxLanguage.SelectedItem = LanguageManager.CurrentLanguage;
            UpdateUsername();

        }


        private void UpdateUsername()
        {
            textBoxUsername.Text = UserManager.CurrentUser.Name;
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
                    panelCenter.BackColor = ColorTranslator.FromHtml("#e1d9ce");
                    panelMenu.BackColor = ColorTranslator.FromHtml("#543310");
                    panelTop.BackColor = ColorTranslator.FromHtml("#74512D");

                    break;
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Hide();
            mainForm.ShowDialog();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            Hide();
            mainForm.ShowDialog();
        }

        public void buttonFav_Click(object sender, EventArgs e)
        {
            if (UserManager.CurrentUser is Guest)
            {
                SignIn signIn = new SignIn();
                signIn.ShowDialog();
            }
            else
            {
                Hide();
                Favorite favorite = new Favorite();
                favorite.ShowDialog();
            }
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            signIn.ShowDialog();
        }

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            if (UserManager.CurrentUser.Name == "Guest")
            {
                signIn.ShowDialog();
            }
            
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLanguage = comboBoxLanguage.SelectedItem.ToString();
            LanguageManager.CurrentLanguage = selectedLanguage;
        }

        private void comboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedTheme = comboBoxTheme.SelectedIndex;
            ThemeManager.CurrentTheme = selectedTheme;
        }

    }
}
