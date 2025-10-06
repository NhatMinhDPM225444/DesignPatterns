using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225444_Phan_Nhat_Minh_Real19_Observer
{
    public class Investor : IInvestor
    {
        private string _name;

        public Investor(string name)
        {
            _name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine($"Notified {_name} of {stock.Symbol}'s change to {stock.Price:C}");
        }
    }
}
