﻿using Entities;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;

namespace CritipediaApi.Auth
{
    public class JwtProvider : ITokenProvider
    {
        private RsaSecurityKey _key;
        private string _algorithm;
        private string _issuer;
        private string _audience;

        public JwtProvider(string issuer, string audience, string keyName)
        {
            var parameters = new CspParameters() { KeyContainerName = keyName };
            var provider = new RSACryptoServiceProvider(2048, parameters);
            _key = new RsaSecurityKey(provider);
            _algorithm = SecurityAlgorithms.RsaSha256Signature;
            _issuer = issuer;
            _audience = audience;
        }


        public string CreateToken(User user, DateTime expiry)
        {
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();

            var claims = new ClaimsIdentity(new List<Claim>()
            {
                new Claim(ClaimTypes.Name, $"{user.Nombre}{user.Apellidos}"),
                new Claim(ClaimTypes.PrimarySid, user.Id.ToString())
            });

            SecurityToken token = tokenHandler.CreateJwtSecurityToken(new SecurityTokenDescriptor
            {
                Audience = _audience,
                Issuer = _issuer,
                SigningCredentials = new SigningCredentials(_key, _algorithm),
                Expires = expiry.ToUniversalTime(),
                Subject = claims
            });

            return tokenHandler.WriteToken(token);
        }

        public TokenValidationParameters GetValidationParameters()
        {
            return new TokenValidationParameters
            {
                IssuerSigningKey = _key,
                ValidAudience = _audience,
                ValidIssuer = _issuer,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.FromSeconds(0)
            };
        }
    }
}
