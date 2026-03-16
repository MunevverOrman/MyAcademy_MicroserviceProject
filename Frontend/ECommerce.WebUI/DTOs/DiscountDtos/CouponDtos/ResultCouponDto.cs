namespace ECommerce.WebUI.DTOs.DiscountDtos.CouponDtos
{
    public class ResultCouponDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int DiscountRate { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
