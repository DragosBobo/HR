
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
        #region Test
        [HttpPost("/test")]
            public async Task<ActionResult> Test()
            {
            var unit = new Unit{
                CUI = "124h1j2gejb2j12",
                UnitName = "testUnit"
            };
            
            _context.Units.Add(unit);
            await _context.SaveChangesAsync();

            var id = unit.Id;
            var user = new User
            {
                Username = "test2",
                Password = "test2",
                UnitId = id,
                SysAdmin = true,
            };
            var user2 = new User
            {
                Username = "test3",
                Password = "test3",
                UnitId = id
            };
            _context.Users.Add(user);
            _context.Users.Add(user2);


            var appUser = new APPUser
            {
                UserId = user.Id,
                RoleId = 2,
                FirstName = "Dragos"
            };
            var appUser2= new APPUser
            {
                UserId = user2.Id,
                RoleId = 2,
                FirstName = "Dragos2"
            };
            _context.AplicationUsers.Add(appUser);
            _context.AplicationUsers.Add(appUser2);

            await _context.SaveChangesAsync();


            var rez = _context.Users.ToList();
            var appUsers = _context.AplicationUsers.ToList();
            var roles = _context.Roles.ToList();

            var unitUsers = _context.Users.Where(x=>x.UnitId == id).ToList();

            return Ok();
            }
        #endregion
       
    }
}


