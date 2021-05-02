using System.Collections.Generic;
using System;

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

        public Scene GetScene(string sceneID)
        {
            for (int i = 0; i <= Scenes.Count; i++)
            {
                if (Scenes[i].ID == sceneID)
                {
                    return Scenes[i];
                }
            }
            throw new ArgumentException("Scene not found");
        }
    }
}