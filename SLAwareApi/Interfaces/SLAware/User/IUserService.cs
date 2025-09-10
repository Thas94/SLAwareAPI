using SLAwareApi.Models.SLAware;

namespace SLAwareApi.Interfaces.SLAware
{
    public interface IUserService
    {
        Task<UserModel> Login(string firstname);
    }
}
