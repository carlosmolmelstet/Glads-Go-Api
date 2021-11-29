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
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime BirthDate { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string CEP { get; set; }
        public string Address { get; set; }
        public string AddressNumber { get; set; }
        public Guid PositionId { get; set; }
        public virtual Position Position { get; set; }
    }
}
