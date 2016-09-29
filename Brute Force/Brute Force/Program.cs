using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Brute_Force
{
    class Program
    {

        static void Main(string[] args)
        {
            int score = 0;
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
            while (dead  == false)
             {
                combostemp.Add(Toetsen[r.Next(0, 5)]);
                File.WriteAllLines(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Lines.txt", combostemp);
                Task.Delay(milliseconds);
                if(score >= prevscore)
                {
                    combos = combostemp;
                    prevscore = score;
                }
            }
        }
    }
}
