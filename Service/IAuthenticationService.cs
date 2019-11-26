using FSL.ApiCustomIdentity.Models;

namespace FSL.ApiCustomIdentity.Service
{
    public interface IAuthenticationService
    {
        AuthenticationResult Authenticate(
            IUser user);
    }
}
