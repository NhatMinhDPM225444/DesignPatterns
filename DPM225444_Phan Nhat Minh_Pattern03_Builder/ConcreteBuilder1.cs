using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DPM225444_Phan_Nhat_Minh_Pattern03_Builder
{
    class ConcreteBuilder1 : Builder
    {
        private Product _product = new Product();

        public override void BuildPartA() => _product.Add("PartA");
        public override void BuildPartB() => _product.Add("PartB");
        public override Product GetResult() => _product;
    }
}
