using System.Collections.Generic;

namespace text_adventure.StoryEngine
{
    public class Scene
    {
        public string ID { get; set; } 
        public string Text { get; set; }
        public bool CanContinue { get; set; }
        public bool CanGoBack { get; set; }
        public string ContinueID { get; set; }
        public string BackID { get; set; }

        public int ActID { get; set; }

        public List<DialogueOption> DialogueOptions { get; set; } = new List<DialogueOption>();

        public void AddDialogueOption(string text, string destinationSceneID)
        {
            DialogueOption option = new DialogueOption();
            option.Text = text;
            option.DestinationSceneID = destinationSceneID;
            DialogueOptions.Add(option);
        }

    }
}