using System.Collections.Generic;

namespace DAL
{
    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<CpuFromProvider> CPUs { get; set; }
        public virtual ICollection<MotherBoardFromProvider> MotherBoards { get; set; }
    }
}