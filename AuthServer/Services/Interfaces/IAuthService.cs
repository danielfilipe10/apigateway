using AuthServer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthServer.Services.Interfaces
{
    public interface IAuthService
    {
        User Authenticate(string username, string password);
    }
}
