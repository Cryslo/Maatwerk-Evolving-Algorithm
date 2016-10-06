using System;
using System.Collections.Generic;
using System.Text;

namespace Bruteforce_AI
{
    public class BruteAI
    {
        static List<string> combos = new List<string>();
        static List<string> combostemp = new List<string>();
        static int prevscore = 0;
        public static List<string> GenerateMovement(int score)
        {
            if(score > prevscore)
            {
                prevscore = score;
                combos = combostemp;
            }
            combostemp.Clear();
            Random r = new Random();
            List<string> Toetsen = new List<string>();
            Toetsen.Add("left");
            Toetsen.Add("right");
            Toetsen.Add("up");
            Toetsen.Add("upright");
            Toetsen.Add("upleft");
            foreach(string item in combos)
            {
                combostemp.Add(item);
            }
            combostemp.Add(Toetsen[r.Next(0, 5)]);
            return combostemp;
        }

    }
}
