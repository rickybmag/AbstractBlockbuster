using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    abstract class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int RunTime { get; set; }


        public List<string> Scenes = new List<string>();

        public Movie(string Title, string Category, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;

        }


        public override string ToString()
        {
            string output = $"Title: {Title}\n";
            output += $"Category: {Category}\n";
            output += $"Runtime: {RunTime}\n";
            return output;
        }
        public abstract void Play();

    }
}
