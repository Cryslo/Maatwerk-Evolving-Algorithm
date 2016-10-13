using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolutie_algoritme
{
    public class Button
    {
        public string cmd;
        public double presstime;
        public bool jump;

        //Constructor
        public Button(string cmd, double presstime, bool jump)
        {
            this.cmd = cmd;
            if (jump == true) { this.presstime = 1; }
            else { this.presstime = presstime; }
            this.jump = jump;
        }

    }
}
