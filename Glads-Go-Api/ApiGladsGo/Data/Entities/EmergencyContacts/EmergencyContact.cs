using ApiGladsGo.Data.Enums;
using ApiMySql.Data.Entities.Positions;
using ApiMySql.Data.Entities.Users;
using System;

namespace ApiMySql.Data.Entities.EmergencyContacts
{
    public class EmergencyContact
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
    }
}
