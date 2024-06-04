using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ЗнижкоСвіт
{
    public static class UserManager
    {
        public static string FilePath = "usersData.json";

        public static List<SignInUser> users = new List<SignInUser>();


        public static People CurrentUser { get; set; } = new Guest(); //встановлення поточного користувача як Guest за замовчуванням

        static UserManager()
        {
            LoadUsers();
        }

        public static void RegisterUser(string name, string password)
        {
            if (!Regex.IsMatch(name, "^[a-zA-Z0-9_.]+$"))
            {
                throw new Exception("Username should contain only English letters, numbers, underscore, and dot.");
            }

            if (!Regex.IsMatch(password, "^[0-9]+$"))
            {
                throw new Exception("Password should contain only numbers.");
            }

            if (name.Length > 20)
            {
                throw new Exception("Username should not exceed 20 characters.");
            }

            if (password.Length < 5)
            {
                throw new Exception("Password should be at least 5 characters long.");
            }

            if (users.Exists(u => u.Name == name))
            {
                throw new Exception("User already exists.");
            }

            SignInUser newUser = new SignInUser(name, password);
            users.Add(newUser);
            SaveUsers();

        }

        
        public static SignInUser LoginUser(string name, string password)
        {
            SignInUser user = users.Find(u => u.Name == name && u.Password == password);
            if (user == null)
            {
                throw new Exception("Invalid username or password.");
            }
            else CurrentUser = user;

            return user;
        }

        public static void LoadUsers()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                users = JsonConvert.DeserializeObject<List<SignInUser>>(json) ?? new List<SignInUser>();
            }
        }

        public static void SaveUsers()
        {
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

    }
}
