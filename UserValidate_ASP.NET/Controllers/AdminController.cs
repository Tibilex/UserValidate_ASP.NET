using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserValidate_ASP.NET.Models;
using UserValidate_ASP.NET.Models.Admin;

namespace UserValidate_ASP.NET.Controllers
{          
    [ApiController]
    [Route("[controller]")]
    public class AdminController : Controller
    {
        private AdminWork m_work = new();

        [HttpGet("GetAll")]
        public IEnumerable<object>GetAll() => m_work.AdminRepository.GetAll();

        [HttpGet("GetToMail")]
        public User? GetUserByMail(string mail) => m_work.AdminRepository.GetUserByMail(mail);

        [HttpPost("Add")]
        public string AddUser([FromForm]User user)
        {
            if (!TryValidateModel(user, nameof(User)))
                return "!!! This email is already registered:";
            ModelState.ClearValidationState(nameof(User));

            if (!m_work.AdminRepository.AddUser(user))
            {
                return "!!! This email is already registered:";
            }             
            return "Registrarion successful:";
        }

        [HttpPost("ChengePassword")]
        public HttpStatusCode ChengePassword([FromForm] User user)
        {
            if (!TryValidateModel(user, nameof(User))) return HttpStatusCode.BadRequest;
            ModelState.ClearValidationState(nameof(user));
            return m_work.AdminRepository.ChengePassword(user);
        }
    }
}
