namespace DAL
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public virtual Producer Producer { get; set; }
        public virtual Provider Provider { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SalaryPrice { get; set; }
        public byte[] Image { get; set; }
    }
}