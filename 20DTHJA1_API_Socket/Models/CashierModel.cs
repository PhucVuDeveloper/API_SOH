namespace _20DTHJA1_API_Socket.Models
{
    public class CashierModel
    {
        public Guid IdCashier { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public int TableNum { get; set; }
    }
}
