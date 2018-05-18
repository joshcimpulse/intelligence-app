using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reportApp
{
    public static class RulesAdmin
    {

        private static List<string> adminUsers = new List<string>();

        private static List<string> adminProviders = new List<string>();

        public static bool IsAdmin(string username)
        {
            if (adminUsers.Count == 0)
            {
                AddAllowedUsers();

            }

            if (adminUsers.Contains(username))
            {
                return true;
            }

            return false;
        }

        private static void AddAllowedUsers()
        {
            adminUsers.Add("IMPULSETECH\\jcaravaggio");
        }


    }
}
