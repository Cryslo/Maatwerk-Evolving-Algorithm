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
            Random r = new Random();
            List<string> Toetsen = new List<string>();
            Toetsen.Add("left");
            Toetsen.Add("right");
            Toetsen.Add("up");
            List<string> combos = new List<string>();
            List<string> combostemp = new List<string>();
            while (0 == 0){
                combostemp.Add(Toetsen[r.Next(0, 3)]);
                File.WriteAllLines(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Lines.txt", combostemp);
                if(score >= prevscore)
                {
                    combos = combostemp;
                    prevscore = score;
                }
            }
        }
    }
}
