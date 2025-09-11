using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225444_Phan_Nhat_Minh_Pattern05_Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator[] creators = {
                new ConcreteCreatorA(),
                new ConcreteCreatorB()
            };

            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }

            Console.ReadKey();
        }
    }
}
