using System;
using System.Collections.Generic;

namespace text_adventure.MansionEngine
{
    public class Floor
    {
        public string Id { get; set; }
        public List<Room> Rooms { get; set;} = new List<Room>();

        public void AddRoom(Room room)
        {
            room.FloorId = this.Id;
            Rooms.Add(room);
        }
        public Room GetRoom(string roomID)
        {
            for (int i = 0; i <= Rooms.Count; i++)
            {
                if (Rooms[i].Id == roomID)
                {
                    return Rooms[i];
                }
            }
            throw new ArgumentException("Scene not found");
        }
    }
}