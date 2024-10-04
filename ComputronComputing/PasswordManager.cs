using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputronComputing
{
    internal class PasswordManager : IDisplayable, IResetable
    {
        public string Password { get; set; }
        public bool Hidden { get; set; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }

        public void Display()
        {
            Console.WriteLine("Password: ");
            if (Hidden)
            {
                Console.WriteLine(new string('*', Password.Length));

            } else
            {
                Console.WriteLine(Password);
            }
        }

        public void Reset()
        {
            Password = "";
            Hidden = false;
        }
    }
}
