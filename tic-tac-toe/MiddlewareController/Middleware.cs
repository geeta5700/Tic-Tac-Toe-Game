using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tic_tac_toe.BackEnd;

namespace tic_tac_toe.MiddlewareController
{
    public class Middleware
    {
        StringBuilder sb;
        FileHandler fh;

        public Middleware()
        {
            this.sb = new StringBuilder();
            fh = new FileHandler();
        }

        public void WriteToBuffer(string str)
        {
            this.sb.Append(str);
            this.fh.WriteToFile(this.sb.ToString());
        }

        public string[] ReadFromBuffer()
        {
            string fileContent = this.fh.ReadFromFile();
            string[] gameMoves = fileContent.Split('\n');

            return gameMoves;
        }
    }
}
