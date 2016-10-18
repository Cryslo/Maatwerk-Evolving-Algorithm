using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolutie_algoritme
{
    public class Genaration_lists : EvolutieAI
    {

        public List<Genaration> Genarations { get; set; }
        List<Button> AlphaSpecies;

        int gencounter = 0;
        int previtem = 0;
        int ScoreCounter;

        public List<Genaration> AddButton()
        {
            List<Button> buttonlist = new List<Button>();
            List<Genaration> genlist = new List<Genaration>();
            List<List<Button>> list = new List<List<Button>>();
            Genaration Gen = new Genaration(list, gencounter);
            if (Gen.List.Count == 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    list.Add(GenerateMovement());
                    Gen.List.Add(list[i]);
                }    
            }
            else {
                for (int i = 0; i < 4; i++)
                {
                    Gen.List.Add(GenerateMovement(Gen.List[i]));
                }

            }
            genlist.Add(Gen);
            Genarations = genlist;
            return genlist;
        }
        public void CreateGen(List<int> Score)
        {
            foreach (Button item in GetAlphaSpecies(Score))
            {
                AlphaSpecies.Add(item);
            }
            Gencounter();
            Genaration Gen = new Genaration(gencounter);
            for (int i = 0; i < 4; i++)
            {
                Gen.List.Add(AlphaSpecies);
                Genarations.Add(Gen);
            }

        }
        private List<Button> GetAlphaSpecies(List<int> Score)
        {
            int x = 0;
            foreach (int item in Score)
            {
                if (item >= previtem)
                {
                    previtem = item;
                    ScoreCounter = x;
                }
                x++;
            }
            return Genarations[gencounter].List[ScoreCounter];
        }
        public int Gencounter()
        {
            return gencounter++;
        }
    }
}
