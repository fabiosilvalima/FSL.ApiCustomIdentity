using FSL.ApiCustomIdentity.Models;

namespace FSL.ApiCustomIdentity.Service
{
    public interface ILoggedUserService
    {
        BaseResult<T> GetLoggedUser<T>()
            where T : class, IUser;
    }
}
