using ApiGladsGo.Data.Enums;
using ApiMySql.Data.Entities.EmergencyContacts;
using ApiMySql.Data.Entities.Positions;
using System;
using System.Collections.Generic;

namespace ApiMySql.Data.Entities.Users
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime BirthDate { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public int JerseyNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CEP { get; set; }
        public string Address { get; set; }
        public string AddressNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Password { get; set; }
        public int Points { get; set; }
        public Role Role { get; set; }
        public Guid PositionId { get; set; }
        public virtual Position Position { get; set; }
        public virtual IEnumerable<EmergencyContact> EmergencyContacts { get; set; }
    }
}
