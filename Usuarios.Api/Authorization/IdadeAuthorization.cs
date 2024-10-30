using Microsoft.AspNetCore.Authorization;

namespace Usuarios.Api.Authorization;

public class IdadeAuthorization : AuthorizationHandler<IdadeMinima>
{
    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IdadeMinima requirement)
    {
        throw new NotImplementedException();
    }
}