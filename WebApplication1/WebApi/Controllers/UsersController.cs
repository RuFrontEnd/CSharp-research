using Application.Users;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly CheckUserExists _useCase;

        public UsersController(CheckUserExists useCase)
        {
            _useCase = useCase;
        }

        [HttpGet("{email}")]
        public IActionResult Exists(string email)
        {
            var exists = _useCase.Execute(email);
            return Ok(new { exists });
        }
    }
}

