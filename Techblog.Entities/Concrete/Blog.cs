using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Techblog.Core.Entities;
using Techblog.Core.Entities.Interfaces;

namespace Techblog.Entities.Concrete
{
    public class Blog : BaseEntity , IEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int Review { get; set; }
        public string Thumbnail { get; set; }
        public string Image { get; set; }
        public Guid CategoryId {get; set;}
        public Guid UserId { get; set; }
        public Category Category { get; set; }
        public User User { get; set; }
    }
}