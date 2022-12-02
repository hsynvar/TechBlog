using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Techblog.Core.Entities.Interfaces;

namespace Techblog.Core.Entities
{
    public class User : BaseEntity , IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string EmailConfirmed { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt  { get; set; }
        public string ProfilePhoto { get; set; }
        public DateTime Birthday { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}