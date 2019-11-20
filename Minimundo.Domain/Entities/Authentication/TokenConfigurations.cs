using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Domain.Entities.Authentication
{
    public class TokenConfigurations
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int Seconds { get; set; }
    }
}
