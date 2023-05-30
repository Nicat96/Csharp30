using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_2
{
    internal class User
    {
        private string userName;
        private string password;

        public string UserName
        {
            get { return userName; }
            private set
            {
                if (value.Length >= 8)
                    userName = value;
                else
                    throw new ArgumentException("UserName minimum 8 karakter olmalıdır.");
            }
        }

        public string Password
        {
            get { return password; }
            private set
            {
                if (value.Length >= 8 && ContainsUpperCase(value) && ContainsLowerCase(value) && ContainsDigit(value))
                    password = value;
                else
                    throw new ArgumentException("Password minimum 8 karakter uzunluğunda olmalı ve en az 1 büyük harf, 1 küçük harf ve 1 rakam içermelidir.");
            }
        }

        private bool ContainsUpperCase(string value)
        {
            foreach (char c in value)
            {
                if (char.IsUpper(c))
                    return true;
            }
            return false;
        }

        private bool ContainsLowerCase(string value)
        {
            foreach (char c in value)
            {
                if (char.IsLower(c))
                    return true;
            }
            return false;
        }

        private bool ContainsDigit(string value)
        {
            foreach (char c in value)
            {
                if (char.IsDigit(c))
                    return true;
            }
            return false;
        }

        public static User CreateUser()
        {
            string username;
            string password;

            while (true)
            {
                Console.Write("Kullanıcı adını girin: ");
                username = Console.ReadLine();
                try
                {
                    User.ValidateUsername(username);
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                Console.Write("Şifreyi girin: ");
                password = Console.ReadLine();
                try
                {
                    User.ValidatePassword(password);
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return new User()
            {
                UserName = username,
                Password = password
            };
        }

        public static void ValidateUsername(string username)
        {
            if (username.Length < 8)
                throw new ArgumentException("UserName minimum 8 karakter olmalıdır.");
        }

        public static void ValidatePassword(string password)
        {
            //if (password.Length < 8 || !ContainsUpperCase(password) || !ContainsLowerCase(password) || !ContainsDigit(password)) 
                throw new ArgumentException("Password minimum 8 karakter uzunluğunda olmalı ve en az 1 büyük harf, 1 küçük harf ve 1 rakam içermelidir.");
        }


    }
}
