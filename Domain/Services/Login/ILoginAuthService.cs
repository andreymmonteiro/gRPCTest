using Domain.Entities.User;
using System.Threading.Tasks;

namespace Domain.Services.Login
{
    public interface ILoginAuthService
    {
        Task<T> FindByLogin<T>(UserEntity user) where T : class;
    }
}
