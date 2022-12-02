using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Techblog.Core.Entities;
using Techblog.Core.Repositories.Concrete.EntityFramework;
using Techblog.DataAccess.Abstract;

namespace Techblog.DataAccess.Concrete.EntityFramework
{
    public class UserDal : GenericRepository<User, AppDbContext> , IUserDal
    {
        
    }
}