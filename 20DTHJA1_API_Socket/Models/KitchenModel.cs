using Google.Api.Ads.AdWords.v201809;

namespace _20DTHJA1_API_Socket.Models
{
    public class KitchenModel
    {
        public Guid IdKitchen { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ImageUrl { get; set; }
        public int CreatedNumber { get; set; }
        public int TableNum { get; set; }
        public int ProductQuantity { get; set; }
        public string ProductNote { get; set; }
    }
}
