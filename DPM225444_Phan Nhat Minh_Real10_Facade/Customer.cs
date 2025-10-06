using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225444_Phan_Nhat_Minh_Real10_Facade
{
    public class Customer
    {
        private string name;
        public Customer(string name)
        {
            this.name = name;
        }

        public string Name { get { return name; } }
    }
}
