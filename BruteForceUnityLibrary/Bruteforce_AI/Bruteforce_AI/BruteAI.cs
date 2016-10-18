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
        float backupscore = 0;
        int timer = 0;
        int failtimer = 0;
        int keycount = 0;
        int jump = 0;
        bool receivescore = false;
        public List<Button> GenerateMovement()
        {
            Random r = new Random();
            if (score < prevscore && combos.Count > 0)
            {
                failtimer++;
                if(failtimer >= 5)
                {
                    if (combos.Count == 1)
                    {
                        combos[combos.Count -1].presstime = GetRandomNumber(0, 3);
                    }
                    else
                    {
                        combos.Remove(combos[combos.Count - 1]);
                    }
                    prevscore = 0;
                    failtimer = 0;
                }
                return combos;
            }
            else if (score == prevscore && receivescore == true)
            {
                failtimer = 0;
                timer++;
                if (timer >= 3)
                {
                    foreach (Button item in combos) iterations.Add(item);
                    combos[r.Next(0, combos.Count)].presstime = r.Next(1, 4);
                    combos[r.Next(0, combos.Count)].jump = Convert.ToBoolean(r.Next(0, 2));
                    timer = 0;
                    prevscore = 0;
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
            Button btn = new Button(Toetsen[keycount], GetRandomNumber(0,3), Convert.ToBoolean(jump));
            keycount++;
            if(keycount == 2) {
                if (jump == 0) {
                    jump = 1;
                }
                else {
                    jump = 0;
                }
                keycount = 0;
            }
            foreach (Button item in combos)
            {
                combostemp.Add(item);
            }
            combostemp.Add(btn);
        }
        public void UpdateScore(float score, float time)
        {
            this.score = score;
            if (score > prevscore)
            {
                backupscore = prevscore;
                prevscore = score;
                prevtime = time;
                keycount = 0;
                jump = 0;
                failtimer = 0;
                receivescore = true;
                combos.Clear();
                foreach (Button item in combostemp)
                {
                    combos.Add(item);
                }
            }
            if (score == prevscore)
            {
                prevscore = score;
                prevtime = time;
                keycount = 0;
                jump = 0;
                failtimer = 0;
            }
        }
        public string getNum()
        {
            string s = "";
            s = "Prevscore/score: " + prevscore.ToString() + " " + score.ToString() + " Failtimer: " + failtimer.ToString();
            return s;
        }
        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }

    public class Button
    {
        public string cmd;
        public double presstime;
        public bool jump;

        //Constructor
        public Button(string cmd, double presstime, bool jump)
        {
            this.cmd = cmd;
            if(jump == true) { this.presstime = 1; }
            else { this.presstime = presstime; }
            this.jump = jump;
        }

    }


}
