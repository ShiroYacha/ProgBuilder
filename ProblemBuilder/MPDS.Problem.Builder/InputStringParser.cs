using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDS.Problem.Builder
{
    public class InputStringParser
    {
        private List<string> rawLines = new List<string>();

        public InputStringParser(string rawString)
        {
            Parse(rawString);
        }

        private void Parse(string rawString)
        {
            foreach (string line in rawString.Split(new string[]{Environment.NewLine},StringSplitOptions.None))
                rawLines.Add(line);
        }

        public List<string> RawLines
        {
            get
            {
                return rawLines;
            }
        }

        public string GetLine(int index)
        {
            if (rawLines.Count > index)
                return rawLines[index];
            throw new ArgumentException("Line doesn't exist!");
        }
    }
}
