using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc; //the view is coming from client angular
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task< ActionResult<IEnumerable<AppUser>>> GetUsers(){  //list offers too many features for what we need
        var users=_context.Users.ToListAsync(); //toList is not an async method
        return await users;

        }
    
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id){  //list offers too many features for what we need
        var user=_context.Users.FindAsync(id);
        return await user;
        }
    }
}