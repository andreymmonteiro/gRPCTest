using Data.Context;
using Data.Repositories;
using Data.Repositories.User;
using Domain.Entities.User;
using Domain.Interfaces;
using Domain.Services.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Data.Implementations
{
    public class UserImplementation : BaseRepository<UserEntity>, IUserRepository
    {
        private DbSet<UserEntity> _dataSet; 

        public UserImplementation(MyContext context) : base(context)
        {
            _dataSet = context.Set<UserEntity>();
        }

        public async Task<UserEntity> FindByLogin(UserEntity user)
        {
            try 
            {
                var result = await _dataSet.AsNoTracking().FirstOrDefaultAsync(item => item.email.Equals(user.email));
                if (user != null && user.password.Equals(result.password))
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
