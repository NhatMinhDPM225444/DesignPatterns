using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225444_Phan_Nhat_Minh_Pattern16_Interator
{
    public abstract class AbstractAggregate
    {
        public abstract Iterator CreateIterator();
    }
}
