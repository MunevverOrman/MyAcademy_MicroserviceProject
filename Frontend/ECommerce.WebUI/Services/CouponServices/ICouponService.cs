using ECommerce.WebUI.DTOs.DiscountDtos.CouponDtos;

namespace ECommerce.WebUI.Services.CouponServices
{
    public interface ICouponService
    {
        Task<ResultCouponDto> GetCouponByCode(string code);

        Task<List<ResultCouponDto>> GetAllAsync();

        Task<ResultCouponDto> GetByIdAsync(int id);

        Task CreateAsync(CreateCouponDto createCouponDto);

        Task UpdateAsync(UpdateCouponDto updateCouponDto);

        Task DeleteAsync(int id);
    }
}
