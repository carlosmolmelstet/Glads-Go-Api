
using ApiMySql.Data.Entities.Users;
using GladsAPI.Repository;
using GladsAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GladsAPI.Controllers
{
    [ApiController]
    [Route("v1")]
    public class LoginController : Controller
    {

        private readonly IUserRepository _repository;

        public LoginController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] User model)
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
    }
}
