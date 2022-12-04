using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace tic_tac_toe.BackEnd
{
    public class FileHandler
    {
        public void WriteToFile(string content)
        {
            File.WriteAllText("game.txt", content);
        }

        public string ReadFromFile()
        {
            return File.ReadAllText("game.txt");
        }
    }
}
