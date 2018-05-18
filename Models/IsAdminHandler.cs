using Microsoft.AspNetCore.Authorization;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace reportApp
{
    public class IsAdminHandler : AuthorizationHandler<IsAdminRequirement>
    {
        private IAppAuthorizationService _appAuthorizationService;

        public IsAdminHandler(IAppAuthorizationService appAuthorizationService)
        {
            _appAuthorizationService = appAuthorizationService;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IsAdminRequirement requirement)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));
            if (requirement == null)
                throw new ArgumentNullException(nameof(requirement));


            if ( _appAuthorizationService.IsAdmin(context.User.Identity.Name))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
