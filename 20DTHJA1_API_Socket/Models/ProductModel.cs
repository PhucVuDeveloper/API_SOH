namespace _20DTHJA1_API_Socket.Models
{
    public class ProductModel
    {
        public Guid IdProduct { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ImageUrl { get; set; }
        public int ProductType { get; set;}
        public int ProductQuantity { get; set; }
        public int ProductStatus { get; set; }

    }
}
