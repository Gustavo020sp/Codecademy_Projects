using System;

namespace OutParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckPasswordStrength("123456789"));
        }

        static string CheckPasswordStrength(string password, out bool isPasswordStrong)
        {
            bool isPasswordStrong;
            
            if (password.length > 8)
            {
                isPasswordStrong = true;
                message = "Sua senha é forte";
                return message;
            }
        }

    }
}