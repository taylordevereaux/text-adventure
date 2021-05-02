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

    }
}