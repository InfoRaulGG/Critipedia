using Entities;
using Microsoft.IdentityModel.Tokens;
using System;

namespace CritipediaApi.Auth
{
    public interface ITokenProvider
    {
        string CreateToken(User user, DateTime expiry);
        TokenValidationParameters GetValidationParameters();

    }
}
