using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225444_Phan_Nhat_Minh_Pattern12_Proxy
{
    public class Proxy : Subject
    {
        private RealSubject realSubject;

        public override void Request()
        {
            // Lazy initialization
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }
            realSubject.Request();
        }
    }
}
