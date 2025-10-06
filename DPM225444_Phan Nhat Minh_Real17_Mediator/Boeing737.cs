using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225444_Phan_Nhat_Minh_Real17_Mediator
{
    public class Boeing737 : Aircraft
    {
        public Boeing737(AirTrafficControlTower tower, string callSign)
            : base(tower, callSign) { }
    }
}
