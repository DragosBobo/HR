
using HrAppDataAcces;
using Microsoft.AspNetCore.Mvc;

namespace HrAppControllers.UserController
{
        [ApiController]
        [Route("api/[controller]")]
        public class UserController : ControllerBase
        {
        private readonly DataBaseContext _context;

        public UserController( DataBaseContext context )
            {
            _context = context;
            }

            [HttpPost]
            public async Task<ActionResult> CreateUser()
            {
            var rez = _context.Users.ToList();
            var appUsers = _context.AplicationUsers.ToList();
            var roles = _context.Roles.ToList();
            return Ok();
            }
       
    }
    }


