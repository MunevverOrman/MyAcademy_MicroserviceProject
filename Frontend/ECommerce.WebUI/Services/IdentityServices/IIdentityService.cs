using ECommerce.WebUI.DTOs.IdentityServerDtos;

namespace ECommerce.WebUI.Services.IdentityServices
{
    public interface IIdentityService
    {
        Task<bool> LoginAsync(LoginDto loginDto);
    }
}
