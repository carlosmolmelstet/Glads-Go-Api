using ApiMySql.Data.Entities.Users;
using ApiMySql.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GladsAPI.Repository
{
    public interface IUserRepository 
    {
        Task<User> Login(string email, string password);
        Task<IEnumerable<User>> GetUsers();
        Task<IEnumerable<User>> GetList();
        Task<ResponseData<User>> Filter(FilterData filter);
        Task<User> GetUser(Guid id);
        Task PutUser(Guid id, User systemUser);
        Task<User> PostUser(User systemUser);
        Task DeleteUser(Guid id);
    }
}
