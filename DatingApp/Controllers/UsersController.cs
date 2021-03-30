using DatingApp.Data;
using DatingApp.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Controllers
{
    [ApiController]
    [Route("datingapp/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext Configration;

        public UsersController(DataContext config)

        {
            Configration = config;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUser()
        {
            return Configration.Users.ToList();

        }

        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUser(int id)
        {
            return Configration.Users.Find(id);

        }
    }
}
