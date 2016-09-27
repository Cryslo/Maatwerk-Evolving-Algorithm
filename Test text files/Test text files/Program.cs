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
            while (0 == 0)
            {
                ConsoleKeyInfo keyinfo;
                keyinfo = Console.ReadKey();
                if (keyinfo.Key == ConsoleKey.A) lines.Add("left");
                if (keyinfo.Key == ConsoleKey.D) lines.Add("right");
                if (keyinfo.Key == ConsoleKey.W) lines.Add("up");
                if (keyinfo.Key == ConsoleKey.Enter)
                {
                  File.WriteAllLines(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Lines.txt", lines);
                }
                if (keyinfo.Key == ConsoleKey.Backspace)
                {
                    lines.Clear();
                    Console.Clear();
                }
            }
           
            
        }
    }
}
