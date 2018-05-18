using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reportApp
{
    public interface IAppAuthorizationService
    {
        bool IsAdmin(string username);
    }
}
