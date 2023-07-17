using Mango.Web.Models;

namespace Mango.Web.Services.IService
{
    public interface IAuthService
    {
        Task<ResponseDTO?> LogInAsync(LoginRequestDTO loginRequestDTO);
        Task<ResponseDTO?> RegisterInAsync(RegistrationRequestDTO registrationRequestDTO);
        Task<ResponseDTO?> AssignRoleAsync(RegistrationRequestDTO registrationRequestDTO);
    }
}
