namespace ECommerce.Discount.Business.Dtos.Coupons;

public record CreateCouponDto(
                           string Code,
                           int DiscountRate,
                            DateTime ExpireDate);

