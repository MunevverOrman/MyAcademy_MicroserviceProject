namespace ECommerce.Basket.Dtos
{
    public class BasketItemDto
    {
        public string ProductId { get; set; }

        public string ProductName { get; set; }

        public string ImageUrl { get; set; }

        public int Quantity { get; set; } //kac tane ürün eklendiği

        public decimal Price { get; set; }
    }
}
