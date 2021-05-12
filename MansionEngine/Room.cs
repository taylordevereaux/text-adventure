using System;
using System.Collections.Generic;

namespace text_adventure.MansionEngine
{
    public class Room
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string FloorId { get; set; }
        public bool CanInspect { get; set; }
        public bool CanOpen { get; set; }
        public bool CanLeave { get; set; }
        
        
        public List<Playerchoice> PlayerChoices { get; set; } = new List<Playerchoice>();

        public void AddPlayerChoice(string text, string destinationSceneID)
        {
            Playerchoice option = new Playerchoice();
            option.Text = text;
            option.DestinationSceneID = destinationSceneID;
            PlayerChoices.Add(option);
        }
    }
}