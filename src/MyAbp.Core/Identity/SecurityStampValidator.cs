using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using MyAbp.Authorization.Roles;
using MyAbp.Authorization.Users;
using MyAbp.MultiTenancy;
using Microsoft.Extensions.Logging;

namespace MyAbp.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options,
            SignInManager signInManager,
            ISystemClock systemClock,
            ILoggerFactory loggerFactory)
            : base(options, signInManager, systemClock, loggerFactory)
        {
        }
    }
}
