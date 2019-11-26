using System.Security.Claims;
using FSL.ApiCustomIdentity.Extensions;
using FSL.ApiCustomIdentity.Models;
using Microsoft.AspNetCore.Http;

namespace FSL.ApiCustomIdentity.Service
{
    public sealed class IdentityLoggedUserService : ILoggedUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IdentityLoggedUserService(
            IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public BaseResult<T> GetLoggedUser<T>()
            where T : class, IUser
        {
            var identity = _httpContextAccessor.HttpContext?.User?.Identity as ClaimsIdentity;
            var result = new BaseResult<T>();
            
            if (identity?.IsAuthenticated ?? false)
            {
                result.Data = identity?.FindFirst("Data")?.Value.FromJson<T>();
                result.Success = result.Data != null;
            }
            
            return result;
        }
    }
}
