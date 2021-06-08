using System;
using System.Collections.Generic;

namespace text_adventure.LocationEngine
{
    public class Location
    {
        public string Name { get; set; }            
        public string Description { get; set; }
        public List<Room> Rooms { get; set; } = new List<Room>();

        public void LoadLocation()
        {
            AbandonedMansion();
        }

        private void AbandonedMansion()
        {
            var room = new Room();
            room.Name = "Main Hall";
            room.Description = "You stand in a grand entry hall, the paint on the walls has long since chipped and faded away, there is what appears to be what was once a table in the centre of the room. \nTo the North you see an old shabby wooden door, barely still on it's hinges. \n To the East there is a hall leading deeper into the mansion. \nTo the South you see a large staircase leading up, as well as a single door. \nTo the West are the giant double doors to which you entered the mansion.";            
            this.AddRoom(room);


        }

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }
    }
}