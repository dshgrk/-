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

namespace ЗнижкоСвіт
{
    public partial class SignUp : KryptonForm
    {
        public SignUp()
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
                    kryptonLabelName.Text = "Створення акаунту";

                    textBoxUsername.CueHint.CueHintText = "Нікнейм";
                    textBoxPassword.CueHint.CueHintText = "Пароль";

                    buttonSignUp.Text = "Реєстрація";
                    labelToSignIn.Text = "Вже маєте акаунт?";

                    break;

                case "English":
                    kryptonLabelName.Text = "Account Creation";
                    kryptonLabelName.Location = new Point(465, 70);

                    textBoxUsername.CueHint.CueHintText = "Username";
                    textBoxPassword.CueHint.CueHintText = "Password";

                    buttonSignUp.Text = "Sign Up";
                    labelToSignIn.Text = "Already have an account?";
                    labelToSignIn.Location = new Point(530, 405);

                    break;

            }
        }

        private void labelToSignIn_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.ShowDialog();
            Close();
        }

        private void buttonExitSignup_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string name = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            try
            {
                UserManager.RegisterUser(name, password);

                DialogResult result = MessageBox.Show("Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    SignIn signIn = new SignIn();
                    signIn.ShowDialog();

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
