using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225444_Phan_Nhat_Minh_Pattern18_Momento
{
    public class Originator
    {
        private string state;

        public string State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("State = " + state);
            }
        }

        public Memento CreateMemento()
        {
            return new Memento(state);
        }

        public void SetMemento(Memento m)
        {
            Console.WriteLine("Restoring state...");
            this.State = m.State;
        }
    }
}
