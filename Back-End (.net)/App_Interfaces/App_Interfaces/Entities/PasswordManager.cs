using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Interfaces.Entities
{
    internal class PasswordManager : IDisplayable, IResetable
    {
        private string Password
        { get; set; }

        public bool Hidden
        { get; private set; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }

        public void Display()
        {
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
            Password = "";
            Hidden = false;
        }
    }
}
