using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reportApp
{
    public static class RulesSalesPerson
    {

        private static List<string> salesPersonUsers = new List<string>();

        private static List<string> salesPersonProviders = new List<string>();

        public static bool IsSalesPerson(string username)
        {
            if (salesPersonUsers.Count == 0)
            {

                AddAllowedUsers();

            }

            if (salesPersonUsers.Contains(username))
            {
                return true;
            }

            return false;
        }

        private static void AddAllowedUsers()
        {

            salesPersonUsers.Add("IMPULSETECH\\jcaravaggio");
        }


    }
}