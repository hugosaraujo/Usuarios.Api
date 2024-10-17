using Microsoft.AspNetCore.Mvc;
using Usuarios.Api.Data.Dto;

namespace Usuarios.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    [HttpPost]
    public IActionResult AdcionaUsuario(CreateUsuarioDto usuarioDto)
    {
        throw new NotImplementedException();
    }
}
