using GladsAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GladsAPI.Controllers
{
    [ApiController]
    [Route("v1")]
    public class UserController : Controller
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => String.Format("Autenticado - {0}", User.Identity.Name);

        [HttpGet]
        [Route("user")]
        [Authorize(Roles = "adm,user")]
        public string Employee() => "User";

        [HttpGet]
        [Route("adm")]
        [Authorize(Roles = "adm")]
        public string Manager() => "Adm";
    }
}
