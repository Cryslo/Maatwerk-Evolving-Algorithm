using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test_text_files
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();
            lines.Add("left");
            lines.Add("right");
            lines.Add("up");
            File.WriteAllLines(@"C:\Users\Luuk\Dropbox\Maatwerk Proftaakgroep\Textfile\Lines.txt", lines);

        }
    }
}
