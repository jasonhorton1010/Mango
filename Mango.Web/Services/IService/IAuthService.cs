using Mango.Web.Models;
using Mango.Web.Models.DTOs;

namespace Mango.Web.Services.IService
{
    public interface IAuthService
    {
        Task<ResponseDTO?> LogInAsync(LoginRequestDTO loginRequestDTO);
        Task<ResponseDTO?> RegisterInAsync(RegistrationRequestDTO registrationRequestDTO);
        Task<ResponseDTO?> AssignRoleAsync(RegistrationRequestDTO registrationRequestDTO);
    }
}
