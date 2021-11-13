using ApiMySql.Data.Entities.Positions;
using ApiMySql.Data.Entities.Users;
using ApiMySql.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechWeekFatecSul.Data;

namespace GladsAPI.Repository
{

    public class UserRepository : IUserRepository
    {
        private readonly TechWeekFatecSulContext _context;

        public UserRepository(TechWeekFatecSulContext context)
        {
            _context = context;
        }


        public async Task<User> Login(string email, string password)
        {
            return (await _context.Users.AsNoTracking().AsQueryable().Include(r => r.Position).ToListAsync()).Where(x => x.Email.ToLower() == email.ToLower() && x.Password == password).FirstOrDefault();
        }

        public async Task<IEnumerable<User>> GetList()
        {
            var result = await _context.Users.AsNoTracking().AsQueryable().Include(r => r.Position).OrderBy(e => e.Name).ToListAsync();
            return result;
        }
        public async Task<IEnumerable<Position>> GetPositions()
        {
            var result = await _context.Positions.OrderBy(e => e.Name).ToListAsync();
            return result;
        }

        public async Task<ResponseData<User>> Filter(FilterData filter)
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

        public async Task<User> GetUser(Guid id)
        {
            return await _context.Users.AsNoTracking().AsQueryable().Include(e => e.Position).Where(e => e.Id == id).FirstOrDefaultAsync();
        }


        public async Task<User> PutUser(User user)
        {

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                return user;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(user.Id))
                {
                    throw new Exception();
                }
                else
                {
                    throw;
                }
            }

        }

        public async Task<User> PostUser(User user)
        {
            var emails = await _context.Users.Select(e => e.Email).ToListAsync();

            if(emails.Contains(user.Email))
            {
                throw new Exception("Email ja cadastrado");
            }

            user.Role = "user";
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task DeleteUser(Guid id)
        {
            var systemUser = await _context.Users.FindAsync(id);
            if (systemUser == null)
            {
                throw new Exception();
            }

            _context.Users.Remove(systemUser);
            await _context.SaveChangesAsync();
        }

        private bool UserExists(Guid id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
