using System;
using System.Collections.Generic;

namespace text_adventure.MansionEngine
{
    public class Object
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
        
    }
}