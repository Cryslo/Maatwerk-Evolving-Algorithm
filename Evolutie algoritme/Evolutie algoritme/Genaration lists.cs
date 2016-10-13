using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolutie_algoritme
{
    public class Genaration_lists : EvolutieAI
    {
        
        List<Genaration> Genarations;
        List<Button> AlphaSpecies;
        
        int gencounter = 0;
        int previtem = 0;
        int ScoreCounter;

        public List<Genaration> AddButton()
        {
            Genaration Gen = new Genaration(gencounter);
            for (int i = 0; i < 4; i++)
            {
                Gen.List.Add(GenerateMovement(Gen.List[i]));
            }
            Genarations.Add(Gen);
            return Genarations;
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
