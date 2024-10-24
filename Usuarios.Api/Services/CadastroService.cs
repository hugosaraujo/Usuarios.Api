﻿using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Usuarios.Api.Data.Dto;
using Usuarios.Api.Models;

namespace Usuarios.Api.Services;

public class CadastroService
{
    private IMapper _mapper;
    private UserManager<Usuario> _userManager;

    public CadastroService(IMapper mapper, UserManager<Usuario> userManager)
    {
        _mapper = mapper;
        _userManager = userManager;
    }

    internal async Task Cadastra(CreateUsuarioDto dto)
    {
        Usuario usuario = _mapper.Map<Usuario>(dto);
        IdentityResult resultado = await _userManager.CreateAsync(usuario, dto.Password);

        if (!resultado.Succeeded) throw new ApplicationException("Falha ao tentar criar usuário.");
        
    }
}
