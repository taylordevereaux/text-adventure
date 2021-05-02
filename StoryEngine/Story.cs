using System;
using System.Collections.Generic;

namespace text_adventure.StoryEngine
{
    public class Story
    {
        public List<Act> Acts { get; set; } = new List<Act>();    

        public void LoadStory()
        {
            LoadAct1();
        }
        private void LoadAct1()
        {
            var act = new Act();
            act.ID = 1;
            //scene 1
            var scene = new Scene();
            scene.ID = "Act_1_1";
            scene.Text = "Welcome to the adventure!";
            scene.CanContinue = true;
            scene.CanGoBack = false;
            scene.ContinueID = "Act_1_2";
            scene.ActID = "Act_1";
            act.AddScene(scene);

            //scene 2
            scene = new Scene();
            scene.ID = "Act_1_2";
            scene.Text = "You are walking down a path and meet a beggar.";
            scene.CanContinue = true;
            scene.CanGoBack = true;
            scene.ContinueID = "Act_1_3";
            scene.BackID = "Act_1_1";
            scene.ActID = "Act_1";
            act.AddScene(scene);

            //scene 3
            scene = new Scene();
            scene.ID = "Act_1_3";
            scene.Text = "The beggar greets you warmly, there is a sparkle in his eye.";
            scene.CanContinue = true;
            scene.CanGoBack = true;
            scene.ContinueID = "Act_1_4";
            scene.BackID = "Act_1_2";
            scene.ActID = "Act_1";
            act.AddScene(scene);

            //scene 4
            scene = new Scene();
            scene.ID = "Act_1_4";
            scene.Text = "Hello stranger, would you be willing to spare a copper for a man down on luck?";
            scene.CanContinue = true;
            scene.CanGoBack = true;
            scene.ContinueID = "Act_1_5";
            scene.BackID = "Act_1_3";
            scene.ActID = "Act_1";
            act.AddScene(scene);

            this.AddAct(act);

        }
        public Act GetAct(int actID)
        {
            for (int i = 0; i <= Acts.Count; i++)
            {
                if (Acts[i].ID == actID) 
                {
                    return Acts[i];
                }
            }
            throw new ArgumentException("Act not found");
        }
        public void AddAct(Act act)
        {
            Acts.Add(act);
        }


    }
}