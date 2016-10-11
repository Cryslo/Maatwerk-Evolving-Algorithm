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
        float prevtime;
        public List<Button> GenerateMovement()
        {
            combostemp.Clear();
            Random r = new Random();
            List<string> Toetsen = new List<string>();
            Toetsen.Add("left");
            Toetsen.Add("right");
            Toetsen.Add("up");
            Button btn = new Button(Toetsen[r.Next(0, 3)], r.Next(1, 4), Convert.ToBoolean(r.Next(0, 1)));
            foreach (Button item in combos)
            {
                combostemp.Add(item);
            }
            combostemp.Add(btn);
            return combostemp;
        }
        public void UpdateScore(float score, float time)
        {
            if (score > prevscore)
            {
                prevscore = score;
                prevtime = time;
                combos.Clear();
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
        public bool jump;

        //Constructor
        public Button(string cmd, int presstime, bool jump)
        {
            this.cmd = cmd;
            this.presstime = presstime;
            this.jump = jump;
        }

    }


}
