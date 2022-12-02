using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Techblog.Core.Entities.Interfaces;

namespace Techblog.Core.Entities
{
    public class UserRole : BaseEntity , IEntity
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }

    }
}