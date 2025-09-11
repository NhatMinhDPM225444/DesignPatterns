using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225444_Phan_Nhat_Minh_Pattern02_Singleton
{
    public class Singleton
    {
        private static Singleton _instance;

        // Constructor is protected
        protected Singleton()
        {
        }

        public static Singleton Instance()
        {
            // Lazy initialization. Not thread-safe
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
