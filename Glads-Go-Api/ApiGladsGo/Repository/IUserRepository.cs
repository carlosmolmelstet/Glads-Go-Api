using ApiMySql.Data.Entities.Positions;
using ApiMySql.Data.Entities.Users;
using ApiMySql.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GladsAPI.Repository
{
    public interface IUserRepository 
    {
        Task<User> Login(string email, string password);
        Task<IEnumerable<Position>> GetPositions();
        Task<IEnumerable<User>> GetList();
        Task<ResponseData<User>> Filter(FilterData filter);
        Task<User> GetUser(Guid id);
        Task<User> PutUser(User user);
        Task<User> PostUser(User user);
        Task DeleteUser(Guid id);
        Task<IEnumerable<User>> UpdatePoints(UpdatePointsDto updatePoints);
    }
}
