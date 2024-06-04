using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ЗнижкоСвіт
{
    public class SignInUser : People
    {
        private string password;

        public List<Card> FavCards { get; set; }

        public SignInUser(string name, string password)
        {
            Name = name;
            Password = password;
            Role = "SignIn";
            FavCards = new List<Card>();
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
