﻿
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Usuarios.Api.Models;

namespace Usuarios.Api.Services;

public class TokenService
{
    public string GenerateToken(Usuario usuario)
    {
        Claim[] claims = new Claim[]
        {
            new Claim("username", usuario.UserName),
            new Claim("id", usuario.Id),
            new Claim(ClaimTypes.DateOfBirth, usuario.DataNascimento.ToString())
        };

        var chave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("FHSIHFAPIUHSDIUHC98H2389H98FHANC"));

        var signInCredentials = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);
        
        var token = new JwtSecurityToken(
            expires: DateTime.Now.AddMinutes(10), 
            claims: claims, 
            signingCredentials: signInCredentials
            );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}