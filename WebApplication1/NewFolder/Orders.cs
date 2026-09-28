namespace WebApplication1.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public int IdCustomer { get; set; }

        public decimal price { get; set; }

        public int stock { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
