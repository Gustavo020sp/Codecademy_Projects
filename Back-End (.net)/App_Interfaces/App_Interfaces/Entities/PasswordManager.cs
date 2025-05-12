using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace App_Interfaces.Entities
{
    public class PasswordManager : IDisplayable, IResetable
    {
        public string HeaderSymbol { get; set; }

        public string _password;
        private string Password
        {
            get {  return _password; }
            set 
            {
                if (Password.Length >= 8)
                {
                    _password = value;
                }
                else
                {
                    throw new ArgumentException("password must be at least 8 caracteres.");
                }
            }
        }

        public bool Hidden
        { get; private set; }

        public PasswordManager(string password, bool hidden)
        {
            _password = password;
            Hidden = hidden;
        }

        public void Display()
        {
            HeaderSymbol = "---------";
            Console.WriteLine(HeaderSymbol);

            if (Hidden)
            {
                Console.Write("Password: ");
                for (int i = 1; i <= Password.Length; i++)
                {
                    Console.Write("*");
                }              
            }
            else
            {
                Console.WriteLine($"Password: {Password}");
            }

        }

        public void Reset()
        {
            Console.WriteLine("reseting password....");
            Password = "";
            Hidden = false;
        }

        public bool ChangePassword(string input, string new_password)
        {
            if (input == Password)
            {
                Password = new_password;
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
