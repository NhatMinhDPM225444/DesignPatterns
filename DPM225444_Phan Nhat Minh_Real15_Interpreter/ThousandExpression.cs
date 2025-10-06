using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225444_Phan_Nhat_Minh_Real15_Interpreter
{
    public class ThousandExpression : Expression
    {
        public override void Interpret(Context context)
        {
            while (context.Input.StartsWith("M"))
            {
                context.Output += 1000;
                context.Input = context.Input.Substring(1);
            }
        }
    }
}
