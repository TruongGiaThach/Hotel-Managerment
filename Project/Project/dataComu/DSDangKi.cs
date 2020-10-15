using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.dataComu
{
    class DSDangKi
    {
        private static DSDangKi instance;

        public static DSDangKi Instance
        {
            get { if (instance == null) instance = new DSDangKi(); return DSDangKi.instance; }
            private set => instance = value;
        }
        private DSDangKi() { }
    }
}
