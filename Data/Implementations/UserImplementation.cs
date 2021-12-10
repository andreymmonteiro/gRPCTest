using Data.Context;
using Data.Repositories;
using Data.Repositories.User;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations
{
    public class UserImplementation : BaseRepository<UserEntity>, IUserRepository
    {
        private DbSet<UserEntity> dataSet;

        public UserImplementation(MyContext context) : base(context)
        {
            dataSet = context.Set<UserEntity>();
        }

        public async Task<UserEntity> FindByLogin(UserEntity user)
        {
            try 
            {
                var result = await dataSet.AsNoTracking().FirstOrDefaultAsync(item => item.id == user.id);
                if (user.password == result.password)
                    return result;
            }
            catch(Exception ex) 
            {
                throw ex;
            }
            user = null;
            return user;
        }
    }
}
