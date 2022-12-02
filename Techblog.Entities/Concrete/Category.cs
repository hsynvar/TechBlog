using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Techblog.Core.Entities;
using Techblog.Core.Entities.Interfaces;

namespace Techblog.Entities.Concrete
{
    public class Category : BaseEntity, IEntity
    {
        public string Name { get; set; }

        public ICollection<Blog> Blogs { get; set; }
    }
}
