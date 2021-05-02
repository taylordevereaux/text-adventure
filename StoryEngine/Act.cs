using System.Collections.Generic;

namespace text_adventure.StoryEngine
{
    public class Act
    {
        public string ID { get; set; }
        public List<Scene> Scenes { get; set; }

        public void LoadAct()
        {
            //scene 1
            var Scene1 = new Scene();
            Scene1.ID = "Act_1_1";
            Scene1.Text = "Welcome to the adventure!";
            Scene1.CanContinue = true;
            Scene1.CanGoBack = false;
            Scene1.ContinueID = "Act_1_2";
            Scene1.ActID = "Act_1";
            Scenes.Add(Scene1);

            //scene 2
            var Scene2 = new Scene();
            Scene2.ID = "Act_1_2";
            Scene2.Text = "You are walking down a path and meet a beggar.";
            Scene2.CanContinue = true;
            Scene2.CanGoBack = true;
            Scene2.ContinueID = "Act_1_3";
            Scene2.BackID = "Act_1_1";
            Scene2.ActID = "Act_1";
            Scenes.Add(Scene2);

            //scene 3
            var Scene3 = new Scene();
            Scene2.ID = "Act_1_3";
            Scene2.Text = "The beggard greets you warmly, there is a sparkle in his eye.";
            Scene2.CanContinue = true;
            Scene2.CanGoBack = true;
            Scene2.ContinueID = "Act_1_4";
            Scene2.BackID = "Act_1_2";
            Scene2.ActID = "Act_1";
            Scenes.Add(Scene3);

            //scene 4
            var Scene4 = new Scene();
            Scene2.ID = "Act_1_4";
            Scene2.Text = "Hello stranger, would you be willing to spare a copper for a man down on luck?";
            Scene2.CanContinue = true;
            Scene2.CanGoBack = true;
            Scene2.ContinueID = "Act_1_5";
            Scene2.BackID = "Act_1_3";
            Scene2.ActID = "Act_1";
            Scenes.Add(Scene4);

        }

        public void GetSceneByID()
        {

        }
    }
}