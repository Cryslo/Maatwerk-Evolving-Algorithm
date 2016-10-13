using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolutie_algoritme
{
    public class EvolutieAI
    {
        public List<Button> combos = new List<Button>();
        public List<Button> combostemp = new List<Button>();
        float prevscore = 0;
        float score = 0;
        bool presschange = false;
        bool receivescore = false;
        public List<Button> GenerateMovement(List<Button> list)
        {
            combostemp.Clear();
            Random r = new Random();
            List<string> Toetsen = new List<string>();
            Toetsen.Add("left");
            Toetsen.Add("right");
            Button btn = new Button(Toetsen[r.Next(0, 2)], GetRandomNumber(0, 3), Convert.ToBoolean(r.Next(0, 2)));
            foreach (Button item in list)
            {
                combostemp.Add(item);
            }
            combostemp.Add(btn);
            return combostemp;
        }
    
        public double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}

