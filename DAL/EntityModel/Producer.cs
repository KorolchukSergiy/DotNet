﻿using System.Collections.Generic;
namespace DAL
{
    public class Producer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<CPU> CPUs { get; set; }
        public virtual ICollection<MotherBoard> MotherBoards { get; set; }
    }
}