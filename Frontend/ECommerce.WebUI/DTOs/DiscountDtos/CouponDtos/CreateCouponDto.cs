namespace ECommerce.WebUI.DTOs.DiscountDtos.CouponDtos
{
    public class CreateCouponDto
    {

        public string Code { get; set; }
        public int DiscountRate { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
