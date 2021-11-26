using Identity.API.Models.AccountModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.API
{
    public interface ITokenManager
    {
        public string GenerateToken(string key, string issuer, LoginModel model);
        public bool IsTokenValid(string key, string issuer, string token);

    }
}
