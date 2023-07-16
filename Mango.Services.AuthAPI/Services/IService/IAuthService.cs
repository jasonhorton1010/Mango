using Mango.Services.AuthAPI.Models.DTOs;

namespace Mango.Services.AuthAPI.Services.IService
{
    public interface IAuthService
    {
        Task<string> Register(RegistrationRequestDTO reqistrationRequestDTO);

        Task<LoginResponseDTO> Login(LoginRequestDTO requestDTO);

        Task<bool> AssignRole(string email, string roleName);
    }
}
