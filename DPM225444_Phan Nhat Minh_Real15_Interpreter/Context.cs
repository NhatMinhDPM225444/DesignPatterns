using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225444_Phan_Nhat_Minh_Real15_Interpreter
{
    public class Context
    {
        public string Input { get; set; }
        public int Output { get; set; }

        public Context(string input)
        {
            Input = input;
            Output = 0;
        }
    }
}
