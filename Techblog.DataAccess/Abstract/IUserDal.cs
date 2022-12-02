using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Techblog.Core.Entities;
using Techblog.Core.Repositories.Abstract;

namespace Techblog.DataAccess.Abstract
{
    public interface IUserDal : IGenericRepository<User>
    {
        
    }
}