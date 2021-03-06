﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
namespace reportApp
{
    public class AppAuthorizationService : IAppAuthorizationService
    {
        public bool IsAdmin(string username)
        {
            return RulesAdmin.IsAdmin(username);
        }
        public bool IsSalesPerson(string username)
        {
            return RulesSalesPerson.IsSalesPerson(username);
        }
    }
}
