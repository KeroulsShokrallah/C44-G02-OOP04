using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_OOP04
{
    internal class BasicAuthenticationService : IAuthenticationService
    {


        bool IAuthenticationService.AuthenticateUser(string username, string password)
        {
            if (username == null || password == null)
            {
                Console.WriteLine($"{username} : authenticated failed");
                return false;
            }

            else
            {
                Console.WriteLine($"{username} : authenticated successfully");
                return true;
            }

        }

        bool IAuthenticationService.AuthorizeUser(string username, string role)
        {
            if (username == null || role == null)
            {
                Console.WriteLine($"{username} : Authorization  failed");
                return false;
            }

            else
            {
                Console.WriteLine($"{username} : authenticated successfully by role {role}");
                return true;
            }


        }
    }
}
