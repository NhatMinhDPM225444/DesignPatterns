using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225444_Phan_Nhat_Minh_Real09_Decorator
{
    public abstract class DecoratorBase : LibraryItem
    {
        protected LibraryItem libraryItem;

        public DecoratorBase(LibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }

        public override void Display()
        {
            libraryItem.Display();
        }
    }
}
