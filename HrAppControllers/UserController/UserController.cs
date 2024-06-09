
using HrAppDataAcces;
using HrAppDataAcces.Entities;
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
            var unit = new Unit{
                CUI = "124h1j2gejb2j12",
                UnitName = "testUnit"
            };
            var user = new User
            {
                Username = "test2",
                Password = "test2",
                UnitId = unit.Id
            };
            _context.Users.Add(user);

            var appUser = new APPUser
            {
                UserId = user.Id,
                RoleId = 2,
                FirstName = "Dragos"
            };
            _context.AplicationUsers.Add(appUser);
            await _context.SaveChangesAsync();

            var id = appUser.Id;

            var rez = _context.Users.ToList();
            var appUsers = _context.AplicationUsers.ToList();
            var roles = _context.Roles.ToList();



            return Ok();
            }
       
    }
    }


