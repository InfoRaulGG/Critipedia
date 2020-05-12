using CritipediaApi.Auth;
using CritipediaDataAccess;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CritipediaApi.Controllers
{
    [ApiController]
    public class LoginController : ControllerBase
    {
        ITokenProvider _tokenProvider;
        IUnitOfWork _work;
        public LoginController(ITokenProvider tokenProvider, IUnitOfWork work)
        {
            _tokenProvider = tokenProvider;
            _work = work;
        }
        [Route("/login")]
        [HttpPost]
        public JsonWebToken Post(UserLogin login)
        {
            var user = _work.RepositoryUser.ValidateUser(login.Email, login.Password);

            if (user == null)
                throw new UnauthorizedAccessException();

            var token = new JsonWebToken
            {
                Access_Token = _tokenProvider.CreateToken(user, DateTime.UtcNow.AddHours(8)),
                Expires_in = 480
            };

            return token;
        }
    }
}