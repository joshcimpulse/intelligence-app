using Microsoft.AspNetCore.Authorization;
using System;
using System.Linq;
using System.Threading.Tasks;
namespace reportApp
{
    public class IsSalesPersonHandler : AuthorizationHandler<IsSalesPersonRequirement>
    {
        private IAppAuthorizationService _appAuthorizationService;

        public IsSalesPersonHandler(IAppAuthorizationService appAuthorizationService)
        {
            _appAuthorizationService = appAuthorizationService;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IsSalesPersonRequirement requirement)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));
            if (requirement == null)
                throw new ArgumentNullException(nameof(requirement));


            if (_appAuthorizationService.IsSalesPerson(context.User.Identity.Name))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
