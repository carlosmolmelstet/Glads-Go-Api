using System;
using System.Collections.Generic;

namespace ApiMySql.Data.Entities.Users
{
    public class UpdatePointsDto
    {
        public int Points { get; set; }
        public virtual IEnumerable<Guid> UserIds { get; set; }
    }
}
