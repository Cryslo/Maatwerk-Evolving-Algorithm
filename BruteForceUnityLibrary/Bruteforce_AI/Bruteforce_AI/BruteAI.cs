using System;
using System.Collections.Generic;
using System.Text;

namespace Bruteforce_AI
{
    public class BruteAI
    {
        public List<Button> combos = new List<Button>();
        public List<Button> combostemp = new List<Button>();
        float prevscore = 0;
        public List<Button> GenerateMovement()
        {
            combostemp.Clear();
            Random r = new Random();
            List<string> Toetsen = new List<string>();
            Toetsen.Add("left");
            Toetsen.Add("right");
            Toetsen.Add("up");
            Button btn = new Button(Toetsen[r.Next(0, 3)], r.Next(1, 4));
            foreach (Button item in combos)
            {
                combostemp.Add(item);
            }
            combostemp.Add(btn);
            return combostemp;
        }
        public void UpdateScore(float score)
        {
            if (score > prevscore)
            {
                prevscore = score;
                foreach (Button item in combostemp)
                {
                    combos.Add(item);
                }
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
