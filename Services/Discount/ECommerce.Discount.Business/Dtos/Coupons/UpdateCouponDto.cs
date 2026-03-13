namespace ECommerce.Discount.Business.Dtos.Coupons;

public record UpdateCouponDto(int Id,
                           string Code,
                           int DiscountRate,
                            DateTime ExpireDate);

