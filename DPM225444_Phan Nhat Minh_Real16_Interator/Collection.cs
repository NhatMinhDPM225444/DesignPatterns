using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225444_Phan_Nhat_Minh_Real16_Interator
{
    public class Collection : IAbstractCollection
    {
        private List<Item> items = new List<Item>();

        public IteratorReal CreateIterator()
        {
            return new IteratorReal(this);
        }

        public int Count => items.Count;

        public Item this[int index]
        {
            get => items[index];
            set => items.Add(value);
        }
    }
}
