namespace DAL
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Producer Producer { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SalryPrice { get; set; }
        public byte[] Image { get; set; }
    }
}