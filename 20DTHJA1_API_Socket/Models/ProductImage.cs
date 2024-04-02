using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;
namespace _20DTHJA1_API_Socket.Models
{
    public class ProductImage
    {
        public Guid IdProduct { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductType { get; set; }
        public int ProductQuantity { get; set; }
        public int ProductStatus { get; set; }
        public IFormFile Image { get; set; }

    }
}
