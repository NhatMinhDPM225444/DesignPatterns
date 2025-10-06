using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225444_Phan_Nhat_Minh_Real14_Command
{
    public interface ICommand
    {
        double Execute(double x, double y);
    }
}
