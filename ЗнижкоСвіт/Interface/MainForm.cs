using Krypton.Toolkit;
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
    public partial class MainForm : Form
    {
        public AppSettings appSettings;
        public Favorite favorite;
        public SignIn signIn;

        private CardManager cardManager;
        private CardUI cardViewManager;

        private Card card1;
        private Card card2;
        private Card card3;
        private Card card4;
        private Card card5;
        private Card card6;
        private Card card7;


        public MainForm()
        {
            InitializeComponent();

            cardManager = new CardManager();
            cardViewManager = new CardUI(tablePanelCards, cardManager);

            AddCards();

            LanguageManager.LanguageChanged += UpdateLanguage;
            UpdateLanguage(this, EventArgs.Empty);

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

            cardViewManager.UpdateTableLayoutPanel();
        }


        //Додавання карток товарів
        public void AddCards()
        {
            card1 = new Card(1, "Манікюр, педикюр з покриттям гель-лаком у студії «Flamingo beauty studio»", "Київ, Героїв полку Азов вулиця, 32", 180, 99, "Images/manic.jpg");
            card2 = new Card(2, "Ламінування, моделювання та фарбування брів та вій у салоні «Beauty Studio 21»", "Харків, Маяковського вулиця, 11", 350, 175, "Images/brows_lashes2.jpg");
            card3 = new Card(3, "Складне фарбування шатуш, балаяж, мелірування або airtouch в салоні краси «Valeri»", "Київ, Берестейський проспект, 106/2", 3500, 1849, "Images/hairValeri.jpg");
            card4 = new Card(4, "Авторський онлайн-курс з англійської мови від міжнародної мовної онлайн-школи «Educado»", "Вся Україна", 1030, 599, "Images/eng_courses.jpg");
            card5 = new Card(5, "До 2 місяців групових занять у басейні у фітнес-клубі «Malibu Fit Pool»", "Харків, Серпова вулиця, 4А", 1670, 799, "Images/swimmingpool.jpg");
            card6 = new Card(6, "До 5 сеансів остеопластичного масажу обличчя у салоні краси «Lavanda»", " Харків, Людвіга Свободи проспект, 39", 1500, 499, "Images/massage.jpg");
            card7 = new Card(7, "Професійна чистка зубів з Air-Flow у стоматологічній клініці «VioWhite»", "Харків, Рогатинська Левада вулиця, 6", 1000, 549, "Images/teeth.jpg");

            if (UserManager.CurrentUser is SignInUser user)
            {
                card1.IsFavorite = user.FavCards.Any(c => c.Id == card1.Id);
                card2.IsFavorite = user.FavCards.Any(c => c.Id == card2.Id);
                card3.IsFavorite = user.FavCards.Any(c => c.Id == card3.Id);
                card4.IsFavorite = user.FavCards.Any(c => c.Id == card4.Id);
                card5.IsFavorite = user.FavCards.Any(c => c.Id == card5.Id);
                card6.IsFavorite = user.FavCards.Any(c => c.Id == card6.Id);
                card7.IsFavorite = user.FavCards.Any(c => c.Id == card7.Id);
            }

            cardManager.AddCard(card1);
            cardManager.AddCard(card2);
            cardManager.AddCard(card3);
            cardManager.AddCard(card4);
            cardManager.AddCard(card5);
            cardManager.AddCard(card6);
            cardManager.AddCard(card7);
        }

        public void UpdateLanguage(object sender, EventArgs e)
        {
            switch (LanguageManager.CurrentLanguage)
            {
                case "Українська":
                    buttonHome.Text = "Головна";
                    buttonFav.Text = "Улюблене";
                    buttonSettings.Text = "Налаштування";

                    card1.Name = "Манікюр, педикюр з покриттям гель-лаком у студії «Flamingo beauty studio»";
                    card1.Address = "Київ, Героїв полку Азов вулиця, 32";
                    card2.Name = "Ламінування, моделювання та фарбування брів та вій у салоні «Beauty Studio 21»";
                    card2.Address = "Харків, Маяковського вулиця, 11";
                    card3.Name = "Складне фарбування шатуш, балаяж, мелірування або airtouch в салоні краси «Valeri»";
                    card3.Address = "Київ, Берестейський проспект, 106/2";
                    card4.Name = "Авторський онлайн-курс з англійської мови від міжнародної мовної онлайн-школи «Educado»";
                    card4.Address = "Вся Україна";
                    card5.Name = "До 2 місяців групових занять у басейні у фітнес-клубі «Malibu Fit Pool»";
                    card5.Address = "Харків, Серпова вулиця, 4А";
                    card6.Name = "До 5 сеансів остеопластичного масажу обличчя у салоні краси «Lavanda»";
                    card6.Address = "Харків, Людвіга Свободи проспект, 39";
                    card7.Name = "Професійна чистка зубів з Air-Flow у стоматологічній клініці «VioWhite»";
                    card7.Address = "Харків, Рогатинська Левада вулиця, 6";

                    break;

                case "English":
                    buttonHome.Text = "Home";
                    buttonFav.Text = "Favorites";
                    buttonSettings.Text = "Settings";

                    card1.Name = "Manicure, pedicure with correction and gel polish in the studio 'Flamingo beauty studio'";
                    card1.Address = "Kyiv, Heroiv polku Azov street, 32";
                    card2.Name = "Lamination, shaping, and coloring of eyebrows and eyelashes in the 'Beauty Studio 21'";
                    card2.Address = "Kharkiv, Mayakovskoho street, 11";
                    card3.Name = "Complex coloring shatush, balayage, highlights or airtouch in the beauty salon 'Valeri'";
                    card3.Address = "Kyiv, Beresteiskyi prospect, 106/2";
                    card4.Name = "Author's online English course from the international language online school 'Educado'";
                    card4.Address = "All Ukraine";
                    card5.Name = "Up to 2 months of group swimming lessons in the fitness club 'Malibu Fit Pool'";
                    card5.Address = "Kharkiv, Serpova street, 4A";
                    card6.Name = "Up to 5 sessions of osteoplastic facial massage in the beauty salon 'Lavanda'";
                    card6.Address = "Kharkiv, Liudvyga Svobody avenue, 39";
                    card7.Name = "Professional teeth cleaning with Air-Flow at the dental clinic 'VioWhite'";
                    card7.Address = "Kharkiv, Rohatynska Levada street, 6";

                    break;
            }
            cardViewManager.UpdateTableLayoutPanel();

        }

        
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Hide();
            appSettings = new AppSettings();
            appSettings.ShowDialog();
        }

        private void buttonFav_Click(object sender, EventArgs e)
        {
            if (UserManager.CurrentUser is Guest)
            {
                //якщо поточний користувач - гість, показую форму входу в додаток
                SignIn signIn = new SignIn();
                signIn.ShowDialog();
            }
            else
            {
                //якщо ж користувач зареєстрований то показую список його збереженого
                Hide();
                Favorite favorite = new Favorite();
                favorite.ShowDialog();
            }
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            signIn = new SignIn();
            signIn.ShowDialog();
        }


    }
}
