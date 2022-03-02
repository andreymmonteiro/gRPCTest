using Domain.Entities.User;
using System.Threading.Tasks;

namespace Data.Repositories.User
{
    public interface IUserRepository
    {
        Task<UserEntity> FindByLogin(UserEntity user);
    }
}
