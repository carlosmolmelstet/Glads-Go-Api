using ApiMySql.Data.Entities.Users;
using GladsAPI.Repository;
using GladsAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace GladsAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class AccountController : Controller
    {

        private readonly IUserRepository _repository;

        public AccountController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [Route("[controller]/login")]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] User model)
        {
            try
            {
                var user = await _repository.Login(model.Email, model.Password);

                // Verifica se o usuário existe
                if (user == null)
                    return NotFound(new { message = "Usuário ou senha inválidos" });

                // Gera o Token
                var token = TokenService.GenerateToken(user);

                // Oculta a senha
                user.Password = "";

                // Retorna os dados
                return new
                {
                    user = user,
                    token = token
                };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}

