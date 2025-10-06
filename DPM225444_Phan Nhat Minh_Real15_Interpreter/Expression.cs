using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225444_Phan_Nhat_Minh_Real15_Interpreter
{
    public abstract class Expression
    {
        public abstract void Interpret(Context context);
    }
}
