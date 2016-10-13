using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolutie_algoritme
{
    public class Genaration
    {
        public List<List<Button>> List;
        public int Generation;

       public Genaration(List<List<Button>> List, int Generation)
        {
            this.List = List;
            this.Generation = Generation;
        }
       public Genaration(int Generation)
        {
            this.Generation = Generation;
        }
    }
}
