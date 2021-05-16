using System;
using System.Collections.Generic;

namespace text_adventure.MansionEngine
{
    public class Location
    {
        public string Name { get; set; }            
        public string Description { get; set; }
        public List<Room> Rooms { get; set; } = new List<Room>();
    }
}