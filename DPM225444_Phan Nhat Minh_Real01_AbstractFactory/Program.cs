using DPM225444_Phan_Nhat_Minh_Real01_AbstractFactory.Client;
using DPM225444_Phan_Nhat_Minh_Real01_AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225444_Phan_Nhat_Minh_Real01_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Africa
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            // America
            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

            Console.ReadKey();
        }
    }
}
