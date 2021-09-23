using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeloOnline.Config
{
    public class AuthenticationOptions
    {
        public const string ISSUER = "VeloOnline";
        public const string AUDIENCE = "Users";
        const string KEY = "ldjfghkjlsdfgsdfgskjdfhgksjldhghdfkjghskdljfgjksdhf";
        public const int LIFETIME = 5;
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.Default.GetBytes(KEY));
        }
    }
}
