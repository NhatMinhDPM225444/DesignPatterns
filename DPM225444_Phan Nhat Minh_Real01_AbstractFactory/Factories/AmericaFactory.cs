using DPM225444_Phan_Nhat_Minh_Real01_AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225444_Phan_Nhat_Minh_Real01_AbstractFactory.Factories
{
    public class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore() => new Bison();
        public override Carnivore CreateCarnivore() => new Wolf();
    }
}
