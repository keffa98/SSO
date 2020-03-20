using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSO1.Models
{
    public class Client
    {
     //   public Client();
        public int AccessTokenLifetime { get; set; }
        public string ClientId { get; set; }
        //  public ICollection<Secret> ClientSecrets { get; set; }
        public string ClientName { get; set; }
        public string ClientUri { get; set; }
        public bool RequireClientSecret { get; set; }
        public IEnumerable<string> AllowedGrantTypes { get; set; }
        public ICollection<string> AllowedScopes { get; set; }
        public ICollection<string> RedirectUris { get; set; }
        public ICollection<string> PostLogoutRedirectUris { get; set; }
        public string LogoutUri { get; set; }
     //   public void ValidateGrantTypes(IEnumerable<string> grantTypes);

    }

}




