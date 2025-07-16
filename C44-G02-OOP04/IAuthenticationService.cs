using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G02_OOP04
{
    internal interface IAuthenticationService
    {
       


       bool AuthenticateUser (string username, string password);
        bool AuthorizeUser(string username, string role);
    }
}
