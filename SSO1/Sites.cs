using SSO1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSO1
{
    public class Sites
    {

        public static IEnumerable<Client> Get()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "",
                   // ClientSecrets = {new Secret("secret".Sha526()) },

           //     AllowedGrantTypes = GrantTypes.ClientCredentials,
             //   AllowedScopes = { "api1", "api2.read_only" },
                }
            };
        }

    }
}