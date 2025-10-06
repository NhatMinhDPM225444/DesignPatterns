using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225444_Phan_Nhat_Minh_Real14_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(new Calculator());

            // User requests operations
            Console.WriteLine("4 + 2 = " + user.Calculate("+", 4, 2));
            Console.WriteLine("4 - 2 = " + user.Calculate("-", 4, 2));
            Console.WriteLine("4 * 2 = " + user.Calculate("*", 4, 2));
            Console.WriteLine("4 / 2 = " + user.Calculate("/", 4, 2));

            Console.ReadKey();
        }
    }
}
