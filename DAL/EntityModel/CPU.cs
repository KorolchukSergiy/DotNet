namespace DAL
{
    public class CPU:Item
    {
        public string Socket { get; set; }
        public int Frequency { get; set; }
        public int Core { get; set; }
        public int Threads { get; set; }
        public string Cash { get; set; }
        public string Video { get; set; }
    }
}