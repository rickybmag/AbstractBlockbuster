using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class DVD : Movie
    {
        public DVD(string Title, string Category, int RunTime, List<string> Scenes) : base(Title, Category, RunTime, Scenes)
        {

        }
        public override void Play()
        {
            Console.WriteLine($"Which scene of the DVD {Title} would you like to watch?");
            string input = Console.ReadLine();
            string scenes;
            int response;


            while (true)
            {
                try
                {
                    response = int.Parse(input);
                    scenes = Scenes[response];
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter an integer between 1 and 6");
                    continue;
                }
            }
            Console.WriteLine($"Scene {response}: {scenes}");

        }
    }
}
