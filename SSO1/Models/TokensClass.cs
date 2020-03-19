using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSO1
{
    public class TokensClass
    {
        public string id { get; set; }
        public int TimeStart { get; set; }
        public int TimeNow { get; set; }
        public bool Accees { get; set; }

        public TokensClass()
        { }

    }
}