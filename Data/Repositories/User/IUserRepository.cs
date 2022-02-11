using Domain.Entities.User;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.User
{
    public interface IUserRepository
    {
        Task<UserEntity> FindByLogin(UserEntity user);
    }
}
