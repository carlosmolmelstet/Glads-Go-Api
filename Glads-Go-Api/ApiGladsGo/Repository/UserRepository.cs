using ApiGladsGo.Data.Enums;
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
        private readonly GladsGoContext _context;

        public UserRepository(GladsGoContext context)
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
            var query = await _context.Users.AsNoTracking().AsQueryable().Include(r => r.Position).ToListAsync();

            if (!String.IsNullOrEmpty(filter.Search))
            {
                var search = filter.Search.ToLower();
                query = query.Where(e =>
                e.Name.ToLower().Contains(search) ||
                e.Surname.ToLower().Contains(search) ||
                e.Position.Name.ToLower().Contains(search) ||
                e.Position.ShortName.ToLower().Contains(search) ||
                e.JerseyNumber.ToString().ToLower().Contains(search))
                .Select(e => e).ToList();
            }

            var total = query.Count();

            var skip = (filter.Page - 1) * filter.PageSize;
            var result = query.Skip(skip).Take(filter.PageSize).OrderBy(e => e.Name).ToList();

            return new ResponseData<User>
            {
                Total = total,
                Data = result
            };
        }

        public async Task<User> GetUser(Guid id)
        {
            return await _context.Users.AsNoTracking().AsQueryable().Include(e => e.Position).Include(e => e.EmergencyContacts).Where(e => e.Id == id).FirstOrDefaultAsync();
        }


        public async Task<User> PutUser(User user)
        {

            var emails = await _context.Users.Where(e => e.Id != user.Id).Select(e => e.Email).ToListAsync();

            if (emails.Contains(user.Email))
            {
                throw new Exception("Email ja cadastrado");
            }
            user.EmergencyContacts = user.EmergencyContacts.Where(e => e.Name != "" && e.Phone != "").ToList();
            user.Role = Role.User;
            var oldEmergencyContacts = await _context.EmergencyContacts.Where(e => e.UserId == user.Id).ToListAsync();
            _context.EmergencyContacts.RemoveRange(oldEmergencyContacts);
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return user;

        }

        public async Task<User> PostUser(User user)
        {
            var emails = await _context.Users.Select(e => e.Email).ToListAsync();

            if (emails.Contains(user.Email))
            {
                throw new Exception("Email ja cadastrado");
            }
            user.EmergencyContacts = user.EmergencyContacts.Where(e => e.Name != "" && e.Phone != "").ToList();
            user.Role = Role.User;

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<IEnumerable<User>> UpdatePoints(UpdatePointsDto updatePoints)
        {
            var users = await _context.Users.Where(e => updatePoints.UserIds.Contains(e.Id)).ToListAsync();
            users.Select(x => { x.Points = x.Points + updatePoints.Points < 0 ? 0 : x.Points + updatePoints.Points; return x; }).ToArray();
            _context.UpdateRange(users);
            await _context.SaveChangesAsync();
            return users;
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
