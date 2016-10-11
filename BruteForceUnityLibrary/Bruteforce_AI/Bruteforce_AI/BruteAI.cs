using System;
using System.Collections.Generic;
using System.Text;

namespace Bruteforce_AI
{
    public class BruteAI
    {
        public List<Button> iterations = new List<Button>();
        public List<Button> combos = new List<Button>();
        public List<Button> combostemp = new List<Button>();
        float prevscore = 0;
        float score = 0;
        float prevtime;
        int timer = 0;
        bool presschange = false;
        bool receivescore = false;
        public List<Button> GenerateMovement()
        {
            Random r = new Random();
            if (score == prevscore && receivescore == true)
            {
                timer++;
                if (timer >= 3)
                {
                    foreach (Button item in combos) iterations.Add(item);
                    combos[r.Next(0, combos.Count)].presstime = r.Next(1, 4);
                    combos[r.Next(0, combos.Count)].jump = Convert.ToBoolean(r.Next(0, 1));
                    timer = 0;
                    presschange = true;
                    return combos;
                }
                else
                {
                    genkey();
                    return combostemp;
                }
            }
            else
            {
                genkey();
                return combostemp;

            }
            
        }
        public void genkey()
        {
            combostemp.Clear();
            Random r = new Random();
            List<string> Toetsen = new List<string>();
            Toetsen.Add("left");
            Toetsen.Add("right");
            Button btn = new Button(Toetsen[r.Next(0, 3)], r.Next(1, 4), Convert.ToBoolean(r.Next(0, 1)));
            foreach (Button item in combos)
            {
                combostemp.Add(item);
            }
            combostemp.Add(btn);
        }
        public void UpdateScore(float score, float time)
        {
            if (presschange == true)
            {
                if(score > prevscore)
                {
                    presschange = false;
                }
                else
                {
                    presschange = false;
                    combos.Clear();
                    foreach (Button item in iterations) combos.Add(item);
                }
            }
            else if (score > prevscore)
            {
                prevscore = score;
                prevtime = time;
                receivescore = true;
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
            if(jump == true) { this.presstime = 1; }
            else { this.presstime = presstime; }
            this.jump = jump;
        }

    }


}
