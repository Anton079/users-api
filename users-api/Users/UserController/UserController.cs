using Microsoft.AspNetCore.Mvc;
using users_api.Users.Models;
using users_api.Users.Repository;

namespace users_api.Users.UserController
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UserController : ControllerBase
    {
        private IUserRepo _userRepo;

        public UserController(IUserRepo userRepo)
        {
            this._userRepo = userRepo;
        }

        [HttpGet("horia")]

        public async Task<ActionResult<List<User>>> GetUsersAsync()
        {
            var users = await _userRepo.GetUsersAsync();

           
            return Ok(users);
        }

      
    }
}
