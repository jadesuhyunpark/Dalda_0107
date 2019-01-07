using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dalda.Data.Users
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly DaldaContext _db;
        public UsersController(DaldaContext db)
        {
        _db = db;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
        return Ok(await _db.Users.ToListAsync());
        }
    }
}