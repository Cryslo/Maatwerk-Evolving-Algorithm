using System;
using System.Collections.Generic;
using System.Text;

namespace Bruteforce_AI
{
    public class BruteAI
    {
        static List<Button> combos = new List<Button>();
        static List<Button> combostemp = new List<Button>();
        static float prevscore = 0;
        public static List<Button> GenerateMovement()
        {
            combostemp.Clear();
            Random r = new Random();
            List<string> Toetsen = new List<string>();
            Toetsen.Add("left");
            Toetsen.Add("right");
            Toetsen.Add("up");
            Toetsen.Add("upright");
            Toetsen.Add("upleft");
            Button btn = new Button(Toetsen[r.Next(0, 5)], r.Next(1, 4));
            combostemp = combos;
            combostemp.Add(btn);
            return combostemp;
        }
        public static void UpdateScore(float score)
        {
            if (score > prevscore)
            {
                prevscore = score;
                combos = combostemp;
            }
        }
    }

    public class Button
    {
        public string cmd;
        public int presstime;

        //Constructor
        public Button(string cmd, int presstime)
        {
            this.cmd = cmd;
            this.presstime = presstime;
        }

    }


}
