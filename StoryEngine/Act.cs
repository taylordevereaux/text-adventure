using System.Collections.Generic;

namespace text_adventure.StoryEngine
{
    public class Act
    {
        public int ID { get; set; }
        public List<Scene> Scenes { get; set; } = new List<Scene>();

        public void AddScene(Scene scene)
        {
            Scenes.Add(scene);
        }

        public void GetSceneByID()
        {

        }
    }
}