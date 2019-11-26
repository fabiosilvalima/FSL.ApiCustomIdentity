using FSL.ApiCustomIdentity.Models;
using Microsoft.AspNetCore.Authorization;

namespace FSL.ApiCustomIdentity.Filters
{
    public sealed class MyAuthorizeAttribute : AuthorizeAttribute
    {
        public MyAuthorizeAttribute() : base(TokenConfiguration.Policy)
        {

        }
    }
}
