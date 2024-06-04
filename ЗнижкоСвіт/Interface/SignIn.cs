using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ЗнижкоСвіт
{
    public partial class SignIn : KryptonForm
    {

        public event Action<string> UserLoggedIn;

        public SignIn()
        {
            InitializeComponent();

            LanguageManager.LanguageChanged += UpdateLanguage;
            UpdateLanguage(this, EventArgs.Empty);
        }

        private void UpdateLanguage(object sender, EventArgs e)
        {
            switch (LanguageManager.CurrentLanguage)
            {
                case "Українська":
                    kryptonLabelName.Text = "Авторизація";
                    textBoxUsername.CueHint.CueHintText = "Нікнейм";
                    textBoxPassword.CueHint.CueHintText = "Пароль";
                    buttonSignIn.Text = "Увійти";
                    LabelToSignUp.Text = "Бажаєте створити акаунт?";

                    break;

                case "English":
                    kryptonLabelName.Text = "Authorization";
                    textBoxUsername.CueHint.CueHintText = "Username";
                    textBoxPassword.CueHint.CueHintText = "Password";
                    buttonSignIn.Text = "Sign In";
                    LabelToSignUp.Text = "Want to create an account?";

                    break;
            }
        }

        private void LabelToSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            Close();
        }

        private void buttonExitLogin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            string name = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            try
            {
                SignInUser user = UserManager.LoginUser(name, password);
                DialogResult result = MessageBox.Show($"Welcome, {user.Name}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    UserManager.CurrentUser.Name = user.Name;

                    UserLoggedIn?.Invoke(user.Name);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
