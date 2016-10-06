using System;
using System.Collections.Generic;
using System.Text;

namespace Bruteforce_AI
{
    public class BruteAI
    {
        public static string GenerateMovement(int score)
        {
            int prevscore = 0;
            int milliseconds = 200;
            bool dead = false;
            Random r = new Random();
            List<string> Toetsen = new List<string>();
            Toetsen.Add("left");
            Toetsen.Add("right");
            Toetsen.Add("up");
            Toetsen.Add("upright");
            Toetsen.Add("upleft");
            List<string> combos = new List<string>();
            List<string> combostemp = new List<string>();
            combostemp.Add(Toetsen[r.Next(0, 5)]);
            return combostemp[0];
        }
    }
}
