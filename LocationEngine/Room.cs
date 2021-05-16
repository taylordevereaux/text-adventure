using System;
using System.Collections.Generic;

namespace text_adventure.MansionEngine
{
    public class Room
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Object> Objects { get; set; } = new List<Object>();    
    }
}