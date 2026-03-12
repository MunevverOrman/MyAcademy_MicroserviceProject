using ECommerce.Basket.Dtos;

namespace ECommerce.Basket.Services
{
    public interface IBasketService
    {
        Task<BasketTotalDto> GetBasketAsync(string userId);

        Task SaveBasketAsync(BasketTotalDto basketTotalDto);

        Task DeleteBasketAsync(string userId);
    }
}
