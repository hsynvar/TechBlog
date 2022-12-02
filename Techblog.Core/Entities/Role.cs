using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Techblog.Core.Entities.Interfaces;

namespace Techblog.Core.Entities
{
    public class Role : BaseEntity , IEntity
    {
        public string Name { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}
