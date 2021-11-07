using ApiMySql.Data.Entities.Positions;
using System;

namespace ApiMySql.Data.Entities.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public Guid PositionId { get; set; }
        public virtual Position Position { get; set; }
    }
}
