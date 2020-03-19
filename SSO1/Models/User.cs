using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSO1.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        }

    }

//namespace IdentityServer4.Models
//{
//    public class Client
//    {
//        public Client();

//        public bool LogoutSessionRequired { get; set; }
//        public bool AlwaysIncludeUserClaimsInIdToken { get; set; }
//        public int IdentityTokenLifetime { get; set; }
//        public int AccessTokenLifetime { get; set; }
//        public int AuthorizationCodeLifetime { get; set; }
//        public int AbsoluteRefreshTokenLifetime { get; set; }
//        public int SlidingRefreshTokenLifetime { get; set; }
//        public TokenUsage RefreshTokenUsage { get; set; }
//        public bool UpdateAccessTokenClaimsOnRefresh { get; set; }
//        public TokenExpiration RefreshTokenExpiration { get; set; }
//        public AccessTokenType AccessTokenType { get; set; }
//        public bool EnableLocalLogin { get; set; }
//        public ICollection<string> IdentityProviderRestrictions { get; set; }
//        public bool IncludeJwtId { get; set; }
//        public ICollection<Claim> Claims { get; set; }
//        public bool AlwaysSendClientClaims { get; set; }
//        public ICollection<string> AllowedScopes { get; set; }
//        public bool AllowOfflineAccess { get; set; }
//        public ICollection<string> AllowedCorsOrigins { get; set; }
//        public string LogoutUri { get; set; }
//        public bool Enabled { get; set; }
//        public string ClientId { get; set; }
//        public string ProtocolType { get; set; }
//        public ICollection<Secret> ClientSecrets { get; set; }
//        public bool RequireClientSecret { get; set; }
//        public string ClientName { get; set; }
//        public string ClientUri { get; set; }
//        public bool PrefixClientClaims { get; set; }
//        public string LogoUri { get; set; }
//        public bool AllowRememberConsent { get; set; }
//        public IEnumerable<string> AllowedGrantTypes { get; set; }
//        public bool RequirePkce { get; set; }
//        public bool AllowPlainTextPkce { get; set; }
//        public bool AllowAccessTokensViaBrowser { get; set; }
//        public ICollection<string> RedirectUris { get; set; }
//        public ICollection<string> PostLogoutRedirectUris { get; set; }
//        public bool RequireConsent { get; set; }

//        public void ValidateGrantTypes(IEnumerable<string> grantTypes);
//    }
//}

