namespace DAL
{
    public class MotherBoardFromProvider:ItemFromProvider
    {
        public string Socket { get; set; }
        public string ChipSet { get; set; }
        public string PciE { get; set; }
        public string RAM { get; set; }
        public string USB { get; set; }
    }
}