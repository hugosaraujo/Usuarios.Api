using Microsoft.AspNetCore.Authorization;

namespace Usuarios.Api.Authorization;

public class IdadeMinima : IAuthorizationRequirement
{
    public IdadeMinima(int idade)
    {
        Idade = idade; 
    }
    public int Idade { get; set; }
}