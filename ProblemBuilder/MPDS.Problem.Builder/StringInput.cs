using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPDS.Problem.Builder
{
    public class StringInput : IInputSystem
    {
        private string inputString;

        public StringInput(string inputString)
        {
            this.inputString = inputString;
        }

        public string Acquire()
        {
            return inputString;
        }
    }
}
