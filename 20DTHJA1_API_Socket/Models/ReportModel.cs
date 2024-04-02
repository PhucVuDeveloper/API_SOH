namespace _20DTHJA1_API_Socket.Models
{
    public class ReportModel
    {
        public Guid IdRep { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public string ReportDate { get; set; }
    }
}
