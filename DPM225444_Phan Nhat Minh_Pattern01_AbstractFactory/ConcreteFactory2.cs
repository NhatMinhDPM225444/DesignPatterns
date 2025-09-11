using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225444_Phan_Nhat_Minh_Pattern01_AbstractFactory
{
    public class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA() => new ProductA2();
        public override AbstractProductB CreateProductB() => new ProductB2();
    }
}
