using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolutie_algoritme
{
    public class Genaration_lists : EvolutieAI
    {
        List<List<List<Button>>> Genarations;
        List<Button> AlphaSpecies;
        int gencounter = 0;
        int previtem = 0;
        int ScoreCounter;

        public List<List<List<Button>>> AddButton()
        {
            for (int i = 0; i < 4; i++)
            {
                Genarations[gencounter].Add(GenerateMovement(Genarations[gencounter][i]));
            }

            return Genarations;
        }
        public void CreateGen(List<int> Score)
        {
            foreach (Button item in GetAlphaSpecies(Score))
            {
                AlphaSpecies.Add(item);
            }
            Gencounter();
            for (int i = 0; i < 4; i++)
            {
                Genarations[gencounter].Add(AlphaSpecies);
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
            return Genarations[gencounter][ScoreCounter];
        }
        public int Gencounter()
        {
            return gencounter++;
        }
    }
}
