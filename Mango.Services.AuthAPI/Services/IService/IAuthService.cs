﻿using Mango.Services.AuthAPI.Models.DTOs;

namespace Mango.Services.AuthAPI.Services.IService
{
    public interface IAuthService
    {
        Task<string> Register(RegistrationRequestDTO reqistrationRequestDTO);

        Task<LoginRequestDTO> Login(LoginRequestDTO requestDTO);
    }
}
