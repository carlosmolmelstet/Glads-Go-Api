using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiMySql.Data;
using ApiMySql.Data.Entities.Users;
using ApiMySql.Data.Entities.Positions;
using TechWeekFatecSul.Data;
using ApiMySql.Models;

namespace ApiMySql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly TechWeekFatecSulContext _context;

        public UsersController(TechWeekFatecSulContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        [HttpGet("/List")]
        public async Task<ActionResult<IEnumerable<User>>> GetList()
        {
            var result = await _context.Users.AsNoTracking().AsQueryable().Include(r => r.Position).OrderBy(e => e.Name).ToListAsync();
            return result;
        }

        [HttpPost("/Filter")]
        public async Task<ActionResult<ResponseData<User>>> Filter(FilterData filter)
        {
            var query = _context.Users.AsNoTracking().AsQueryable().Include(r => r.Position).OrderBy(e => e.Name);

            var total = query.Count();

            var skip = (filter.Page - 1) * filter.PageSize;
            var result = query.Skip(skip).Take(filter.PageSize).ToList();

            return new ResponseData<User>
            {
                Total = total,
                Data = result
            };
        }
        [HttpGet("/Positions")]
        public async Task<ActionResult<IEnumerable<Position>>> GetPositions()
        {
            var result = await _context.Positions.OrderBy(e => e.Name).ToListAsync();
            return result;
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(Guid id)
        {
            var systemUser = await _context.Users.FindAsync(id);

            if (systemUser == null)
            {
                return NotFound();
            }

            return systemUser;
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(Guid id, User systemUser)
        {
            if (id != systemUser.Id)
            {
                return BadRequest();
            }

            _context.Entry(systemUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Users
        [HttpPost("/Save")]
        public async Task<ActionResult<User>> PostUser([FromBody] User systemUser)
        {
            _context.Users.Add(systemUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = systemUser.Id }, systemUser);
        }

        // DELETE: api/Users/5
        [HttpDelete("/Delete/{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var systemUser = await _context.Users.FindAsync(id);
            if (systemUser == null)
            {
                return NotFound();
            }

            _context.Users.Remove(systemUser);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(Guid id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
