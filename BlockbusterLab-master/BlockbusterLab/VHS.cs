using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public VHS(string Title, string Category, int RunTime, List<string> Scenes) : base(Title, Category, RunTime, Scenes)
        {
            this.CurrentTime = 0;
        }
        public override void Play()
        {
            string scenes;

            while (true)
            {
                try
                {
                    scenes = Scenes[CurrentTime];
                    CurrentTime += 1;
                    break;
                }
                catch (ArgumentOutOfRangeException)
                {                   
                    continue;
                }
            }
            Console.WriteLine($"Scene {CurrentTime}: {scenes}");

        }
        
    }
}
