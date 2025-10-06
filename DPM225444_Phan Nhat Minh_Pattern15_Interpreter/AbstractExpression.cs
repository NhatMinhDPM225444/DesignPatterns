using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225444_Phan_Nhat_Minh_Pattern15_Interpreter
{
    public abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }
}
