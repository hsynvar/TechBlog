using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Techblog.Core.Entities;
using Techblog.Entities.Concrete;

namespace Techblog.DataAccess.Concrete.EntityFramework
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                builder
                    .UseSqlServer("Server=localhost,1433;Initial Catalog=Techblog;Persist Security Info=False;User Id=sa;Password=rena12345;MultipleActiveResultSets=true;;TrustServerCertificate=true",
                    opt =>
                    {
                        opt.EnableRetryOnFailure();
                    });
            }
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}
