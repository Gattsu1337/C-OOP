using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3.Exercise_3
{
    internal sealed class MySingleton
    {
        private MySingleton() { }
        public static MySingleton instance = null;
        public static MySingleton Instance
        {
            get {
                if (instance == null)
                {
                    instance = new MySingleton();
                }
                return instance;
            }
        }
    }
}
