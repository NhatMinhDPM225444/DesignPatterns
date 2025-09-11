using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225444_Phan_Nhat_Minh_Pattern02_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructor is protected — cannot use 'new'
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            // Test for same instance
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }

            Console.ReadKey();
        }
    }
}
