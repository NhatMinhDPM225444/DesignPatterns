using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225444_Phan_Nhat_Minh_Real17_Mediator
{
    public abstract class Aircraft
    {
        protected AirTrafficControlTower tower;
        public string CallSign { get; }

        protected Aircraft(AirTrafficControlTower tower, string callSign)
        {
            this.tower = tower;
            this.CallSign = callSign;
        }

        public void Send(string message)
        {
            tower.Send(message, this);
        }

        public virtual void Receive(string message)
        {
            Console.WriteLine($"{CallSign} received: {message}");
        }
    }
}
