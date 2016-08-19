using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace Site.Security
{
    public class CustomPrincipal : IPrincipal
    {
        public CustomPrincipal(string name)
        {
            Identity = new GenericIdentity(name);
        }
        public IIdentity Identity
        {
            private set;
            get;
        }

        public bool IsInRole(string role)
        {
            if (!Roles.Any(r => role.Contains(r)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string[] Roles { get; set; }
        public string Name { get; set; }
    }
}