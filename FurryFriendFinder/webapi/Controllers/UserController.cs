using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.BusinessLogic.UserLogic;
using webapi.Common.DTO.User;
using webapi.UnitOfWork;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserBusinessLogic userBusinessLogic;

        public UserController(IUserBusinessLogic userBusinessLogic)
        {
            this.userBusinessLogic = userBusinessLogic;
        }

        [HttpPost, Route("Register")]
        public Task<bool> RegisterUser(UserAddDto userData)
        {
            userBusinessLogic.CreateUser(userData);
            return Task.FromResult(true);
        }
    }
}
