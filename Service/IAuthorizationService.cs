using FSL.ApiCustomIdentity.Models;

namespace FSL.ApiCustomIdentity.Service
{
    public interface IAuthorizationService
    {
        BaseResult<IUser> Authorize(
            LoginUser loginUser);
    }
}
