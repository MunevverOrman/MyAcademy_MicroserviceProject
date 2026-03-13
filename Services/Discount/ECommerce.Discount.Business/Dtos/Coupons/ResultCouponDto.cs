namespace ECommerce.Discount.Business.Dtos.Coupons;

public record ResultCouponDto(int Id,
                               string Code,
                               int DiscountRate,
                                DateTime ExpireDate);

