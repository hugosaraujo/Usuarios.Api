using AutoMapper;
using Usuarios.Api.Data.Dto;
using Usuarios.Api.Models;

namespace Usuarios.Api.Profiles;

public class UsuariosProfile : Profile
{
    public UsuariosProfile()
    {
        CreateMap<CreateUsuarioDto, Usuario>();
    }
}
